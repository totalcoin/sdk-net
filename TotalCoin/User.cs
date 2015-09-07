using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace TotalCoin
{
    [DataContract]
    public class User
    {
        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public string FullName { get; set; }

        [DataMember]
        public string Email { get; set; }
    }
}
