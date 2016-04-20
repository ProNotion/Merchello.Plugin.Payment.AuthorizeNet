namespace Merchello.Plugin.Payments.AuthorizeNet.Models
{
	public class AuthorizeNetAccountSettings
	{
		public AuthorizeNetAccountSettings()
		{
			// set the defaults
			DelimitedData = true;
			DelimitedChar = "|";
			Method = "CC";
		}

		/// <summary>
		/// Gets or sets a value indicating whether to use the Authorize.Net Sandbox.
		/// </summary>
		/// <value>
		///   <c>true</c> if we should use the sandbox otherwise, <c>false</c>.
		/// </value>
		public bool UseSandbox { get; set; }

		/// <summary>
		/// Gets or sets the currency code.
		/// </summary>
		/// <value>
		/// The currency code.
		/// </value>
		public string CurrencyCode { get; set; }

		/// <summary>
		/// Gets or sets the login identifier.
		/// </summary>
		/// <value>
		/// The login identifier.
		/// </value>
		public string LoginId { get; set; }

		/// <summary>
		/// Gets or sets the transaction key.
		/// </summary>
		/// <value>
		/// The transaction key.
		/// </value>
		public string TransactionKey { get; set; }

		/// <summary>
		/// Gets or sets the method.
		/// </summary>
		/// <value>
		/// The method.
		/// </value>
		public string Method { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether data is delimited.
		/// </summary>
		/// <value>
		///   <c>true</c> if data is delimited otherwise, <c>false</c>.
		/// </value>
		public bool DelimitedData { get; set; }

		/// <summary>
		/// Gets or sets the delimited character.
		/// </summary>
		/// <value>
		/// The delimited character.
		/// </value>
		public string DelimitedChar { get; set; }

		/// <summary>
		/// Gets or sets the encap character.
		/// </summary>
		/// <value>
		/// The encap character.
		/// </value>
		public string EncapChar { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether [relay response].
		/// </summary>
		/// <value>
		///   <c>true</c> if [relay response]; otherwise, <c>false</c>.
		/// </value>
		public bool RelayResponse { get; set; }
	}
}
