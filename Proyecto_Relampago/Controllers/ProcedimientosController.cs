using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_Relampago.Controllers
{
    public class ProcedimientosController : Controller
    {
        // GET: Procedimientos
        public ActionResult Procedimientos()
        {
            return View();
        }

        // GET: Procedimientos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Procedimientos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Procedimientos/Create
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

        // GET: Procedimientos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Procedimientos/Edit/5
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

        // GET: Procedimientos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Procedimientos/Delete/5
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
