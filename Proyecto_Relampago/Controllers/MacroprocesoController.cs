using Logica;
using Proyecto_Relampago.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_Relampago.Controllers
{
    public class MacroprocesoController : Controller
    {
        private Macroproceso_Logica logicaMacroproceso = new Macroproceso_Logica();

        // GET: Macroprocesos
        public ActionResult Macroprocesos()
        {
            DataTable dtMacroprocesos = logicaMacroproceso.ObtenerTodosLosMacroprocesos();
            List<Macroproceso> macroprocesos = new List<Macroproceso>();

            foreach (DataRow row in dtMacroprocesos.Rows)
            {
                Macroproceso macroproceso = new Macroproceso
                {
                    idMacroproceso = row["idMacroproceso"].ToString(),
                    nombreMacroproceso = row["nombreMacroproceso"].ToString()
                };

                macroprocesos.Add(macroproceso);
            }

            return View(macroprocesos);
        }

        // GET: Macroprocesos/Details/5
        public ActionResult Details(string id)
        {
            var dataTable = logicaMacroproceso.ObtenerMacroprocesoPorId(id);
            if (dataTable.Rows.Count == 0)
            {
                return HttpNotFound();
            }

            var row = dataTable.Rows[0];
            Macroproceso macroproceso = new Macroproceso
            {
                idMacroproceso = row["idMacroproceso"].ToString(),
                nombreMacroproceso = row["nombreMacroproceso"].ToString()
            };

            return View(macroproceso);
        }

        // GET: Macroprocesos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Macroprocesos/Create
        [HttpPost]
        public ActionResult Create(Macroproceso macroproceso)
        {
            try
            {
                logicaMacroproceso.AgregarMacroproceso(macroproceso.idMacroproceso, macroproceso.nombreMacroproceso);

                return RedirectToAction("Macroprocesos");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(macroproceso);
            }
        }

        // GET: Macroprocesos/Edit/5
        public ActionResult Edit(string id)
        {
            var dataTable = logicaMacroproceso.ObtenerMacroprocesoPorId(id);
            if (dataTable.Rows.Count == 0)
            {
                return HttpNotFound();
            }

            var row = dataTable.Rows[0];
            Macroproceso macroproceso = new Macroproceso
            {
                idMacroproceso = row["idMacroproceso"].ToString(),
                nombreMacroproceso = row["nombreMacroproceso"].ToString()
            };

            return View(macroproceso);
        }

        // POST: Macroprocesos/Edit/5
        [HttpPost]
        public ActionResult Edit(Macroproceso macroproceso)
        {
            try
            {
                logicaMacroproceso.EditarMacroproceso(macroproceso.idMacroproceso, macroproceso.nombreMacroproceso);

                return RedirectToAction("Macroprocesos");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(macroproceso);
            }
        }

        // GET: Macroprocesos/Delete/5
        public ActionResult Delete(string id)
        {
            var dataTable = logicaMacroproceso.ObtenerMacroprocesoPorId(id);
            if (dataTable.Rows.Count == 0)
            {
                return HttpNotFound();
            }

            var row = dataTable.Rows[0];
            Macroproceso macroproceso = new Macroproceso
            {
                idMacroproceso = row["idMacroproceso"].ToString(),
                nombreMacroproceso = row["nombreMacroproceso"].ToString()
            };

            return View(macroproceso);
        }

        // POST: Macroprocesos/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                logicaMacroproceso.EliminarMacroproceso(id);

                return RedirectToAction("Macroprocesos");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }
        }
    }
}
