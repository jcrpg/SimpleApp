using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace SimpleAppJc.Domain
{
    public partial class Car
    {
        [DataMember]
        public int CarId { get; set; }

        [DataMember]
        public string Model { get; set; }

        [DataMember]
        public string PriceType { get; set; }

        [DataMember]
        public double? EgcPrice { get; set; }

        [DataMember]
        public double? DapPrice { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string ContactName { get; set; }

        [DataMember]
        public string phone { get; set; }

        [DataMember]
        public string Abn { get; set; }

        [DataMember]
        public string Comments { get; set; }



    }
}
