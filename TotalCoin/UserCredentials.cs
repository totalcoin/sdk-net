using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalCoin
{
	/// <summary>
	/// Represents UserCredentials class
	/// </summary>
	public class UserCredentials
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UserCredentials"/> class.
		/// </summary>
		public UserCredentials()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="UserCredentials"/> class.
		/// </summary>
		/// <param name="email">The email.</param>
        /// <param name="apiKey">The application key.</param>
		public UserCredentials(string email, Guid apiKey)
		{
			this.Email = email;
			this.ApiKey = apiKey;
		}

		/// <summary>
		/// Gets or sets the email.
		/// </summary>
		/// <value>
		/// The email.
		/// </value>
		public string Email { get; set; }
		/// <summary>
		/// Gets or sets the application key.
		/// </summary>
		/// <value>
		/// The application key.
		/// </value>
		public Guid ApiKey { get; set; }


	}
}
