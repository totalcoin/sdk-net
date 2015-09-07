using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace TotalCoin
{

	/// <summary>
	/// Represents an AuthorizeResponse entity
	/// </summary>
	[DataContract]
	public class AuthorizeResponse
	{
		/// <summary>
		/// Gets or sets the token identifier.
		/// </summary>
		/// <value>
		/// The token identifier.
		/// </value>
		[DataMember]
		public Guid TokenId { get; set; }
		/// <summary>
		/// Gets or sets the name of the user.
		/// </summary>
		/// <value>
		/// The name of the user.
		/// </value>
		[DataMember]
		public string UserName { get; set; }

	}

}
