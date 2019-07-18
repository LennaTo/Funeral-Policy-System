using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace FuneralPolicyApp.Models
{
    public class Dependant
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string DependentType { get; set; }

        public string PolicyNo { get; set; }

        public string SumAssured { get; set; }

    }

}