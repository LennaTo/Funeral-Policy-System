using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FuneralPolicyApp.Models
{
    public class Claim
    {
        public int ID { get; set; }
        public string ClaimNo { get; set; }

        public int DeceaseDependentId { get; set; }
        public float ClaimAmount { get; set; }

        public float PolicyId { get; set; }

        public virtual ICollection<ClaimFile> ClaimFiles { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/mm/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime ClaimDate { get; set; }

    }
}