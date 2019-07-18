using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using FuneralPolicyApp.Models;
using FuneralPolicyApp.ViewModels;

namespace FuneralPolicySystem.Controllers
{
    public class DependantController : Controller
    {
        private ApplicationDbContext _context;
        public DependantController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Dependant
        public ActionResult Index()
        {
            return View(_context.Dependants.ToList());
        }

        public ActionResult RegisterClaim(int dependantID)
        {
            ViewBag.DependantID = dependantID;
            this.Session["DependantID"] = dependantID;
            return View();

        }

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