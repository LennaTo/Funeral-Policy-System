using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FuneralPolicyApp.Models
{
    public class Premium
    {
        public int ID { get; set; }
        public float PremiumAmount { get; set; }
        public int PolicyId { get; set; }

        public string PolicyNo { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/mm/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime PaymentDate { get; set; }

    }
}