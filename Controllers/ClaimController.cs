using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FuneralPolicyApp.Models;

namespace FuneralPolicyApp.Controllers
{
    public class ClaimController : Controller
    {


        private ApplicationDbContext _context;
        public ClaimController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Claim
        public ActionResult Index()
        {
            return View(_context.Claims.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Claim claim)
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

                claim.ClaimFiles= claimfiles;
                _context.Claims.Add(claim);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(claim);
        }



    }
}