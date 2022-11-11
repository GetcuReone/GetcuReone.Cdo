using GetcuReone.Cdi;
using GetcuReone.Cdi.Extensions;
using GetcuReone.Cdo.File;
using GetcuReone.Cdo.Folder;
using GetcuReone.Cdo.Process;
using System;
using System.IO;
using System.Net.Mail;
using System.Reflection;
using System.Text;

namespace GetcuReone.Cdo.Email
{
    /// <summary>
    /// Service for email.
    /// </summary>
    public class EmailService : BaseGrFactory, IEmail
    {
        /// <inheritdoc/>
        protected override string FactoryName => nameof(EmailService);

        /// <inheritdoc/>
        public void OpenEmail(Cdm.Communication.Email email)
        {
            string emailfile = GetAdapter<CurrentFolderAdapter>().GetFullName("temp.eml");

            OpenEmail(email, emailfile);
        }

        /// <inheritdoc/>
        public void OpenEmail(Cdm.Communication.Email email, string fileEmail)
        {
            var mailMessage = new MailMessage
            {
                Subject = email.Subject,
                Body = email.Body,
                From = new MailAddress(email.From),
            };

            foreach (var recipient in email.To)
                mailMessage.To.Add(new MailAddress(recipient));

            if (!email.Attachments.IsNullOrEmpty())
                foreach (var att in email.Attachments)
                    mailMessage.Attachments.Add(new Attachment(att));

            mailMessage.IsBodyHtml = email.IsBodyHtml;

            using (FileStream fileStream = GetAdapter<FileAdapter>().Open(fileEmail, FileMode.Create))
            {
                using (var binaryWriter = new BinaryWriter(fileStream))
                {
                    //Write the Unsent header to the file so the mail client knows this mail must be presented in "New message" mode
                    binaryWriter.Write(Encoding.UTF8.GetBytes("X-Unsent: 1" + Environment.NewLine));

                    var assembly = typeof(SmtpClient).Assembly;
                    var mailWriterType = assembly.GetType("System.Net.Mail.MailWriter");

                    // Get reflection info for MailWriter contructor
                    var mailWriterContructor = mailWriterType.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new[] { typeof(Stream) }, null);

                    // Construct MailWriter object with our FileStream
                    var mailWriter = mailWriterContructor.Invoke(new object[] { fileStream });

                    // Get reflection info for Send() method on MailMessage
                    var sendMethod = typeof(MailMessage).GetMethod("Send", BindingFlags.Instance | BindingFlags.NonPublic);

                    sendMethod.Invoke(mailMessage, BindingFlags.Instance | BindingFlags.NonPublic, null, new object[] { mailWriter, true, true }, null);

                    // Finally get reflection info for Close() method on our MailWriter
                    var closeMethod = mailWriter.GetType().GetMethod("Close", BindingFlags.Instance | BindingFlags.NonPublic);

                    // Call close method
                    closeMethod.Invoke(mailWriter, BindingFlags.Instance | BindingFlags.NonPublic, null, new object[] { }, null);
                }
            }

            GetAdapter<ProcessAdapter>().Start(fileEmail, string.Empty);
        }
    }
}
