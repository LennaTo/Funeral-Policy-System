using FuneralPolicyApp.Models;
using FuneralPolicyApp.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;

namespace FuneralPolicyApp.Controllers.API
{
    public class PoliciesController : ApiController
    {
        private ApplicationDbContext _context;

        public PoliciesController()
        {
            _context = new ApplicationDbContext();
        }
        // GET API/policies
        public IEnumerable<PolicyDto> GetPolicies()
        {
            return _context.Policies.ToList().Select(Mapper.Map<Policy, PolicyDto>);
        }

        // GET API/policies/1
        public PolicyDto GetPolicy(int Id)
        {
            var policy = _context.Policies.SingleOrDefault(c => c.ID == Id);
            if (policy == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return Mapper.Map<Policy, PolicyDto>(policy);
        }

        [HttpPost]
        // POST API/policies
        public Policy AddPolicy(Policy policy)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.Policies.Add(policy);
            _context.SaveChanges();

            return policy;

        }

        [HttpPut]
        public void UpdatePolicy(int Id, PolicyDto policyDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var policyInDB = _context.Policies.SingleOrDefault(c => c.ID == Id);

            if (policyInDB == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(policyDto, policyInDB);

            

            _context.SaveChanges();


        }
    }
}
