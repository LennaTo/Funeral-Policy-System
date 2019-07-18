using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuneralPolicyApp.Models
{
    public class Commission
    {
        public int ID { get; set; }
        public int PolicyID { get; set; }

        public string PolicyNo { get; set; }
        public int PremiumID { get; set; }
        public string AgentName { get; set; }

        public float CommissionAmount { get; set; }
    }
}