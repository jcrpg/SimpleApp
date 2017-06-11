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
        public string Make { get; set; }
        [DataMember]
        public string Model { get; set; }

        [DataMember]
        public int Year { get; set; }
        [DataMember]
        [Display(Name ="Price Type")]
        public string PriceType { get; set; }

        [DataMember]
        [Display(Name ="Exclude Government Charge Price")]
        public double? EgcPrice { get; set; }

        [DataMember]
        [Display(Name ="Drive Away Price")]
        public double? DapPrice { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        [Display(Name ="Contact Fullname")]
        public string ContactName { get; set; }

        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        [Display(Name ="ABN")]
        public string Abn { get; set; }

        [DataMember]
        public string Comments { get; set; }



    }
}
