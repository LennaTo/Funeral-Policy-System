using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FuneralPolicyApp.Models;

namespace FuneralPolicyApp.Controllers
{
    public class SubscriberController : Controller
    {
        private ApplicationDbContext _context;
        public SubscriberController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Subscriber
        public ActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "SuperAdmin")]
        public ActionResult Add()
        {
            return View();

        }

        [HttpPost]
        public ActionResult Add(Subscriber subscriber)
        {
            _context.Subscribers.Add(subscriber);
            _context.SaveChanges();
            return RedirectToAction("/");
            
        }
    }
}