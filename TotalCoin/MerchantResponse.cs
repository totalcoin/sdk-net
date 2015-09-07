using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace TotalCoin
{
    /// <summary>
    /// Represents a MerchantResponse class
    /// </summary>
    [DataContract]
    public class MerchantResponse
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        /// <value>
        /// The Id.
        /// </value>
        [DataMember]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The Name.
        /// </value>
        [DataMember]
        public string Name{ get; set; }
    }
}
