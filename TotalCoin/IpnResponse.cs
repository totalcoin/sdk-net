using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace TotalCoin
{
    [DataContract]
    public class IpnResponse
    {
        [DataMember]
        public string Reference { get; set; }

        [DataMember]
        public string MerchantReference{ get; set; }

        [DataMember]
        public string TransactionType{ get; set; }

        [DataMember]
        public string Reason{ get; set; }

        [DataMember]
        public string Currency{ get; set; }

        [DataMember]
        public decimal PaidAmount{ get; set; }

        [DataMember]
        public decimal NetAmount{ get; set; }

        [DataMember]
        public decimal FinancingCost{ get; set; }

        [DataMember]
        public decimal TotalAmount{ get; set; }

        [DataMember]
        public IList<TransactionHistories> TransactionHistories{ get; set; }

        [DataMember]
        public MerchantResponse Merchant{ get; set; }

        [DataMember]
        public User FromUser{ get; set; }

        [DataMember]
        public User ToUser{ get; set; }

        [DataMember]
        public Provider Provider{ get; set; }
    }
}
