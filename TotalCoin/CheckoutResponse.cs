using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace TotalCoin
{
	/// <summary>
	/// Represents a CheckoutResponse class
	/// </summary>
	[DataContract]
	public class CheckoutResponse
	{
        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        [DataMember]
        public string URL { get; set; }
	}
}
