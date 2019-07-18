using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuneralPolicyApp.Models
{
    public class PolicyComment
    {
        public int ID { get; set; }
        public string PolicyNo { get; set; }
        public string Comment { get; set; }
    }
}