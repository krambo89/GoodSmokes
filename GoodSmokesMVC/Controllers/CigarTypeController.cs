using GoodSmokes.Models.CigarType;
using GoodSmokesService.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSmokesMVC.Controllers
{
    [Authorize]
    public class CigarTypeController : Controller
    {
        // GET: CigarType

        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Index()
        {
            var service = CreateCigarTypeService();
            var model = service.GetCigarTypes();
            return View(model);
        }
     
        [HttpPost]
        public ActionResult Create(CigarTypeCreate model)
        {

            var service = CreateCigarTypeService();

            if (service.CreateCigarType(model))
            {
                TempData["SaveResult"] = "Your Type was created.";
                return RedirectToAction("Index");
            }


            ModelState.AddModelError("", "Type could not be created");
            return View(model);
        }

        public ActionResult Details(int id)
        {

            var svc = CreateCigarTypeService();
            var model = svc.GetCigarTypeById(id);
            return View(model);
        }

        public ActionResult Edit(int id)
        {

            var service = CreateCigarTypeService();
            var detail = service.GetCigarTypeById(id);
            var model =
                new CigarTypeEdit
                {
                    
                    CigarTypeName = detail.CigarTypeName,
                    
                };

            return View(model);
        }

        [HttpPost]

        public ActionResult Edit(int id, CigarTypeEdit model)
        {
            if (!ModelState.IsValid)
            {


                return View(model);
            }

            if (model.CigarTypeId != id)
            {

                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = CreateCigarTypeService();

            if (service.UpdateCigarType(model))
            {
                TempData["SaveResult"] = "Your cigar type was updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your cigar type could not be updated.");
            return View();
        }

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = CreateCigarTypeService();
            var model = svc.GetCigarTypeById(id);

            return View(model);
        }

        // POST: Note/Delete/{id}
        [HttpPost]
        [ActionName("Delete")]

        public ActionResult DeleteCigarType(int id)
        {
            var service = CreateCigarTypeService();
            service.DeleteCigarType(id);

            TempData["SaveResult"] = "Your cigar type was deleted.";
            return RedirectToAction("Index");
        }

        private CigarTypeService CreateCigarTypeService()
        {
            
            var service = new CigarTypeService();
            return service;
        }

    }
}