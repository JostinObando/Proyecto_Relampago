using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_Relampago.Controllers
{
    public class GraficaController : Controller
    {
        // GET: Grafica
        public ActionResult Index()
        {
            return View();
        }

        // GET: Grafica/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Grafica/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Grafica/Create
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

        // GET: Grafica/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Grafica/Edit/5
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

        // GET: Grafica/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Grafica/Delete/5
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
