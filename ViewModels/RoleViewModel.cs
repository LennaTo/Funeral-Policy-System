using FuneralPolicyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuneralPolicyApp.ViewModels
{
    public class RoleViewModel
    {
        public RoleViewModel() { }

        public RoleViewModel(ApplicationRole role)

        {
            Id = role.Id;
            RoleName = role.Name;
        }

        public string Id { get; set; }

        public string RoleName { get; set; }
    }
}