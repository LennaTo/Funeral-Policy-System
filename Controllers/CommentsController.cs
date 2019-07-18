using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FuneralPolicyApp.Models;

namespace FuneralPolicyApp.Controllers
{
    public class CommentsController : Controller
    {


        private ApplicationDbContext _context;
        public CommentsController()
        {
            _context = new ApplicationDbContext();
        }
       


    }
}