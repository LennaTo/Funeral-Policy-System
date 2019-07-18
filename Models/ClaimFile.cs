using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuneralPolicyApp.Models
{
    public class ClaimFile
    {
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public string Extension { get; set; }
        public int ClaimId { get; set; }
        public virtual Claim Claim { get; set; }
    }
}