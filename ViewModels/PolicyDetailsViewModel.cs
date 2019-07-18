using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FuneralPolicyApp.Models;

namespace FuneralPolicyApp.ViewModels
{
    public class PolicyDetailsViewModel
    {
        public Subscriber Subscriber { get; set; }
        public Policy Policy { get; set; }
    }
}