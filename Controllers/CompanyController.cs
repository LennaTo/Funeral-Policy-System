using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FuneralPolicyApp.Models;

namespace FuneralPolicyApp.Controllers
{
    public class CompanyController : Controller
    {
        private ApplicationDbContext _context;
        public CompanyController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Company
        public ActionResult Index()
        {
            var companies = _context.Companies.ToList();
            return View(companies);
        }


        [Authorize(Roles = "SuperAdmin")]
        [Authorize]

        public ActionResult Add()
        {
            return View();
        }

        [Authorize(Roles = "SuperAdmin")]
        [Authorize]
        [HttpPost]
        public ActionResult Add(Company company)
        {
            _context.Companies.Add(company);
            return RedirectToAction("/");
        }
    }
}