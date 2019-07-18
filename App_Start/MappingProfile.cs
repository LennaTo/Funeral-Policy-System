using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using FuneralPolicyApp.Models;
using FuneralPolicyApp.Dtos;

namespace FuneralPolicyApp.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Policy, PolicyDto>();
            Mapper.CreateMap<PolicyDto, Policy>();

        }
        
    }
}