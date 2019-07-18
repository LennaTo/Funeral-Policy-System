using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FuneralPolicyApp.Models;

namespace FuneralPolicyApp.Controllers
{
    public class CommissionController : Controller
    {
        private ApplicationDbContext _context;
        public CommissionController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Commission
        public ActionResult Index()
        {
            return View(_context.Commissions.ToList());
        }
    }
}