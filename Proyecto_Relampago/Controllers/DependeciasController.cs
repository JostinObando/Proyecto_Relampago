using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_Relampago.Controllers
{
    public class DependeciasController : Controller
    {
        // GET: Dependecias
        public ActionResult Dependecias()
        {
            return View();
        }

        // GET: Dependecias/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Dependecias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dependecias/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Dependecias/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Dependecias/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Dependecias/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Dependecias/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
