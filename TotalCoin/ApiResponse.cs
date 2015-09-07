using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace TotalCoin
{
	/// <summary>
	/// Represents an Response entity
	/// </summary>
	[DataContract]
	public class ApiResponse<T>
	{
        public ApiResponse() 
        {
        }

        public ApiResponse(bool isOk, string message, T response)
        {
            IsOk = isOk;
            Message = message;
            Response = response;
        }
		/// <summary>
		/// Gets or sets a value indicating whether this instance is ok.
		/// </summary>
		/// <value>
		///   <c>true</c> if this instance is ok; otherwise, <c>false</c>.
		/// </value>
		[DataMember]
		public bool IsOk { get; set; }
		/// <summary>
		/// Gets or sets the error message.
		/// </summary>
		/// <value>
		/// The error message.
		/// </value>
		[DataMember]
		public string Message { get; set; }
        /// <summary>
        /// Gets or sets the response.
        /// </summary>
        /// <value>
        /// The error response.
        /// </value>
        [DataMember]
        public T Response { get; set; }
	}

}
