using GoodSmokes.Models;
using GoodSmokesService.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSmokesMVC.Controllers
{
    public class CigarController : Controller
    {
        // GET: Cigar
        public ActionResult Index()
        {
            var model = new CigarListItems[0];
            return View(model);
        }
        // POST: Cigar/Create
        
        
        public ActionResult Create()
        {
            
            return View();
        }

        public ActionResult Details()
        {
            
            return View();
        }

    }
}