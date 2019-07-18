using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FuneralPolicyApp.Models;

namespace FuneralPolicyApp.ViewModels
{
    public class AddPolicyViewModel
    {
        public IEnumerable<Company> Companies { get; set; }
        public IEnumerable<PolicyStatus> PolicyStatuses { get; set; }
        public IEnumerable<Subscriber> Subscribers { get; set; }
        public Policy Policy { get; set; }
    }
}