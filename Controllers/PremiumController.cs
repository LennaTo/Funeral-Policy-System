using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FuneralPolicyApp.Models;

namespace FuneralPolicyApp.Controllers
{
    public class PremiumController : Controller
    {
        private ApplicationDbContext _context;
        public PremiumController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Premium
        public ActionResult Index()
        {
            return View(_context.Premiums.ToList());
        }

        public ActionResult AddPremium()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddPremium(Premium premium)
        {
            float commission_rate = 0.15f;
            
            var commission = new Commission()
            {
                PremiumID = premium.ID,
                CommissionAmount = premium.PremiumAmount * commission_rate,
                PolicyID = premium.PolicyId,
                PolicyNo = getPolicyNoFromId(premium.PolicyId),
                AgentName = getAgentFromPolicy(premium.PolicyId),
            };

            premium.PolicyNo = commission.PolicyNo;


            
            _context.Premiums.Add(premium);
            _context.Commissions.Add(commission);
            _context.SaveChanges();

            return RedirectToAction("/");
        }


        public string getAgentFromPolicy(int PolicyId)
        {
            var AgentName = _context.Policies.SingleOrDefault(m => m.ID == PolicyId);
            return AgentName.AgentName;
        }


        public string getPolicyNoFromId(int PolicyId)
        {
            var policy = _context.Policies.SingleOrDefault(m => m.ID == PolicyId);
            return policy.PolicyNo;
        }
    }
}