﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_Relampago.Controllers
{
    public class MacroServiciosController : Controller
    {
        // GET: MacroServicios
        public ActionResult MacroServicios()
        {
            return View();
        }

        // GET: MacroServicios/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MacroServicios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MacroServicios/Create
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

        // GET: MacroServicios/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MacroServicios/Edit/5
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

        // GET: MacroServicios/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MacroServicios/Delete/5
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
