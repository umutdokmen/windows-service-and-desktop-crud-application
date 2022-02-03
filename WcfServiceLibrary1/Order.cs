using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary1
{
    [DataContract]
    public class Order
    {
        [DataMember]
        public int OrderNo { get; set; }

        [DataMember]
        public string OrderDesc { get; set; }

        [DataMember]
        public DateTime OrderDate { get; set; }

        [DataMember]
        public int OrderQuantity { get; set; }

        [DataMember]
        public DateTime OrderCreationDate { get; set; }

        [DataMember]
        public string CreatedBy { get; set; }
    }
}
