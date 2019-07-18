using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FuneralPolicyApp.Dtos
{
    public class PolicyDto
    {
        public int ID { get; set; }
        public string PolicyNo { get; set; }
        public float Premium { get; set; }
        public float SumAssured { get; set; }

        public int CompanyId { get; set; }

        public int SubscriberId { get; set; }

        public int AgentId { get; set; }

        public string Status { get; set; }

        
        [DataType(DataType.Date)]
        public DateTime DateWritten { get; set; }


    }
}