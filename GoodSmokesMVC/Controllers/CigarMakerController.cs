using GoodSmokes.Models;
using GoodSmokes.Models.CigarMaker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSmokesMVC.Controllers
{
    [Authorize]
    public class CigarMakerController : Controller
    {
        // GET: CigarMaker
        
        public ActionResult Index()
        {
            var model = new CigarMakerListItems[0];
            return View(model);
        }
        // POST: CigarMaker/Create
        
        public ActionResult Create(CigarMakerCreate model)
        {
            if (ModelState.IsValid)
            {

            }
            return View(model);
        }
    }
}