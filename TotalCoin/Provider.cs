using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace TotalCoin
{
    [DataContract]
    public class Provider
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string PaymentMethod { get; set; }
    }
}
