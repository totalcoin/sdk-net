using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace TotalCoin
{
    [DataContract]
    public class TransactionHistories
    {
        [DataMember]
        public string Date { get; set; }

        [DataMember]
        public string TransactionState { get; set; }
    }
}
