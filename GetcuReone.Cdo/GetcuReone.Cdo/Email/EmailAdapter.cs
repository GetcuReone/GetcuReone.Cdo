using GetcuReone.ComboPatterns.Adapter;

namespace GetcuReone.Cdo.Email
{
    /// <summary>
    /// Adapter for <see cref="IEmail"/>.
    /// </summary>
    public sealed class EmailAdapter : AdapterProxyBase<IEmail>
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public EmailAdapter() : base(() => new EmailService()) { }

        /// <inheritdoc cref="IEmail.OpenEmail(Cdm.Communication.Email)"/>
        public void OpenEmail(Cdm.Communication.Email email)
        {
            CreateProxy().OpenEmail(email);
        }

        /// <inheritdoc cref="IEmail.OpenEmail(Cdm.Communication.Email, string)"/>
        public void OpenEmail(Cdm.Communication.Email email, string fileEmail)
        {
            CreateProxy().OpenEmail(email, fileEmail);
        }
    }
}
