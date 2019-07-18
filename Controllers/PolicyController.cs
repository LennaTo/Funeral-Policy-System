using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using FuneralPolicyApp.Models;
using FuneralPolicyApp.ViewModels;

namespace FuneralPolicyApp.Controllers
{
    public class PolicyController : Controller
    {


        private ApplicationDbContext _context;
        public PolicyController()
        {
            _context = new ApplicationDbContext();
        }


        [Authorize]
        // GET: Policy
        public ActionResult Index()
        {
            if (User.IsInRole("SuperAdmin"))
                return View("AdminIndex",_context.Policies.ToList());

            return View("SubscriberList", _context.Policies.ToList());
        }

        [Authorize(Roles = "SuperAdmin")]
        [Authorize]
        public ActionResult Add() {

            var companies = _context.Companies.ToList();
            var statuses = _context.PolicyStatuses.ToList();
            var subscribers = _context.Subscribers.ToList();

            var viewModel = new AddPolicyViewModel
            {
                Companies = companies,
                Subscribers = subscribers
            };

            return View(viewModel);
        }


        [Authorize(Roles = "SuperAdmin")]
        [HttpPost]
        public ActionResult Add(AddPolicyViewModel viewModel) {

            viewModel.Policy.AgentName = User.Identity.Name;
            viewModel.Policy.PolicyNo = "FPS" + "00" + viewModel.Policy.ID.ToString();
            viewModel.Policy.Status = "Active";
            _context.Policies.Add(viewModel.Policy);
            _context.SaveChanges();

            return RedirectToAction("Index");

        }

        [Authorize]
        public ActionResult Details(int id)
        {
            var policy = _context.Policies.SingleOrDefault(c => c.ID == id);
            var policyholder = _context.Subscribers.SingleOrDefault(c => c.SubscriberID == policy.SubscriberId);
            var statuses = _context.PolicyStatuses;

            if (policy == null)
            {
                return HttpNotFound();
            }

            var viewModel = new PolicyDetailsViewModel()
            {
                Policy = policy,
                Subscriber = policyholder

                
            };

            return View(viewModel);
        }


        [Authorize(Roles = "Staff")]
        [Authorize]
        public ActionResult AddDependant(string PolicyNo)
        {
            ViewBag.PolicyNo = PolicyNo;
            this.Session["PolicyNo"] = PolicyNo;
            return View();
        }


        [Authorize(Roles = "Staff")]
        [Authorize]
        [HttpPost]
        public ActionResult AddDependant(Dependant dependant)
        {
            
            _context.Dependants.Add(dependant);
            _context.SaveChanges();
            return RedirectToAction("/","Dependant");
        }


        // GET: Comments
        public ActionResult ViewComments()
        {
            return View(_context.PolicyComments.ToList());
        }

        public ActionResult ViewDependants(string PolicyNo)
        {
            var dependants = _context.Dependants.Where(c => c.PolicyNo == PolicyNo).ToList();
            return View(dependants);

        }

        public ActionResult AddComment(string PolicyNo)
        {
            ViewBag.PolicyNo = PolicyNo;
            this.Session["PolicyNo"] = PolicyNo;
            return View();
        }

        [HttpPost]
        public ActionResult AddComment(PolicyComment policyComment)
        {
            _context.PolicyComments.Add(policyComment);
            _context.SaveChanges();
            return RedirectToAction("ViewComments", "Policy");
        }


        [Authorize(Roles = "Staff")]
        [Authorize]
        public ActionResult RegisterClaim(int dependantID)
        {
            ViewBag.DependantID = dependantID;
            this.Session["DependantID"] = dependantID;
            return View();

        }


        [Authorize(Roles = "Staff")]
        [Authorize]
        [HttpPost]
        public ActionResult RegisterClaim(Claim claim)
        {
            if (ModelState.IsValid)
            {
                List<ClaimFile> claimfiles = new List<ClaimFile>();
                for (int i = 0; i < Request.Files.Count; i++)
                {
                    var file = Request.Files[i];

                    if (file != null && file.ContentLength > 0)
                    {
                        var fileName = Path.GetFileName(file.FileName);
                        ClaimFile claimFile = new ClaimFile()
                        {
                            FileName = fileName,
                            Extension = Path.GetExtension(fileName),
                            Id = Guid.NewGuid()
                        };
                        claimfiles.Add(claimFile);

                        var path = Path.Combine(Server.MapPath("~/App_Data/Upload/"), claimFile.Id + claimFile.Extension);
                        file.SaveAs(path);
                    }
                }

                claim.ClaimFiles = claimfiles;
                _context.Claims.Add(claim);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(claim);

        }


    }
}