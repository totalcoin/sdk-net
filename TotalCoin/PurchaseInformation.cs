using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace TotalCoin
{
	/// <summary>
	/// Represents a PurchaseInformation class
	/// </summary>
	[DataContract]
	public class PurchaseInformation
	{
		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		/// <value>
		/// The description.
		/// </value>
		[DataMember]
		public string Description { get; set; }
		/// <summary>
		/// Gets or sets the amount.
		/// </summary>
		/// <value>
		/// The amount.
		/// </value>
		[DataMember]
		public decimal Amount { get; set; }
		/// <summary>
		/// Gets or sets the currency.
		/// </summary>
		/// <value>
		/// The currency.
		/// </value>
		[DataMember]
		public string Currency { get; set; }
        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>
        /// The quantity.
        /// </value>
        [DataMember]
        public int Quantity { get; set; }
		/// <summary>
		/// Gets or sets the country.
		/// </summary>
		/// <value>
		/// The country.
		/// </value>
		[DataMember]
		public string Country { get; set; }
		/// <summary>
		/// Gets or sets the reference.
		/// </summary>
		/// <value>
		/// The reference.
		/// </value>
		[DataMember]
		public string Reference { get; set; }
		/// <summary>
		/// Gets or sets the payment methods.
		/// </summary>
		/// <value>
		/// The payment methods.
		/// </value>
		[DataMember]
		public string PaymentMethods { get; set; }
		/// <summary>
		/// Gets or sets the site.
		/// </summary>
		/// <value>
		/// The site.
		/// </value>
		[DataMember]
		public string Site { get; set; }
		/// <summary>
		/// Gets or sets the success URL.
		/// </summary>
		/// <value>
		/// The success URL.
		/// </value>
		[DataMember]
		public string SuccessURL { get; set; }
		/// <summary>
		/// Gets or sets the failure URL.
		/// </summary>
		/// <value>
		/// The failure URL.
		/// </value>
		[DataMember]
		public string FailureURL { get; set; }
		/// <summary>
		/// Gets or sets the pending URL.
		/// </summary>
		/// <value>
		/// The pending URL.
		/// </value>
		[DataMember]
		public string PendingURL { get; set; }
        /// <summary>
        /// Gets or sets the merchant.
        /// </summary>
        /// <value>
        /// The merchant.
        /// </value>
        [DataMember]
        public Guid MerchantId { get; set; }
        /// <summary>
        /// Gets or sets the Operation Channel.
        /// </summary>
        /// <value>
        /// The Operation Channel.
        /// </value>
        [DataMember]
        public string OperationChannel { get; set; }
	}
}
