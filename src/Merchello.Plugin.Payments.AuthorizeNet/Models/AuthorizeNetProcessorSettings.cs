namespace Merchello.Plugin.Payments.AuthorizeNet.Models
{
	using System.Collections.Generic;

	public class AuthorizeNetProcessorSettings
    {
        public AuthorizeNetProcessorSettings()
        {
			// Initialize the accounts collection
	        Accounts = new List<AuthorizeNetAccountSettings> { new AuthorizeNetAccountSettings() };
        }

		public List<AuthorizeNetAccountSettings> Accounts { get; set; } 


        public string ApiVersion
        {
            get { return AuthorizeNetPaymentProcessor.ApiVersion; }
        }
    }
}