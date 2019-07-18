using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FuneralPolicyApp.Models
{
    public class Company
    {
        public int ID { get; set; }
        [Required]
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Prefix { get; set; }

      
    }
}