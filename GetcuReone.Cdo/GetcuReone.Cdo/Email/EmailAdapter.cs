using GetcuReone.Cdi;

namespace GetcuReone.Cdo.Email
{
    /// <summary>
    /// Adapter for <see cref="IEmail"/>.
    /// </summary>
    public sealed class EmailAdapter : GrAdapterProxyBase<IEmail>
    {
        /// <inheritdoc/>
        protected override string AdapterName => nameof(EmailAdapter);

        /// <summary>
        /// Constructor.
        /// </summary>
        public EmailAdapter() : base(() => new EmailService())
        {
        }

        /// <summary>
        /// Open email in default email program.
        /// </summary>
        /// <param name="email"></param>
        public void OpenEmail(Cdm.Communication.Email email)
        {
            CallMethodLogging(email);
            CreateProxy().OpenEmail(email);
            ReturnLogging();
        }

        /// <summary>
        /// Open email in default email program.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="fileEmail"></param>
        public void OpenEmail(Cdm.Communication.Email email, string fileEmail)
        {
            CallMethodLogging(email);
            CreateProxy().OpenEmail(email, fileEmail);
            ReturnLogging();
        }
    }
}
