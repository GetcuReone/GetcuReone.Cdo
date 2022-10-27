using EmailRequest = GetcuReone.Cdm.Communication.Email;

namespace GetcuReone.Cdo.Email
{
    /// <summary>
    /// Service for email.
    /// </summary>
    public interface IEmail
    {
        /// <summary>
        /// Open email in default email program.
        /// </summary>
        /// <param name="email">Email Information</param>
        void OpenEmail(EmailRequest email);

        /// <summary>
        /// Open email in default email program.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="fileEmail">Email Information</param>
        void OpenEmail(EmailRequest email, string fileEmail);
    }
}
