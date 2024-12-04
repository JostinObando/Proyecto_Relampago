using Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Proyecto_Relampago.Models;
namespace Proyecto_Relampago.Controllers
{
    public class EstrategiaController : Controller
    {
        // GET: Estrategia
        private EjeEstrategico_Logica logicaEjeEstrategico = new EjeEstrategico_Logica();
        public ActionResult Estrategia()
        {
            DataTable dtEjesEstrategicos = logicaEjeEstrategico.ObtenerTodosLosEjesEstrategicos();
            List<EjeEstrategico> ejesEstrategicos = new List<EjeEstrategico>();

            foreach (DataRow row in dtEjesEstrategicos.Rows)
            {
                EjeEstrategico ejeEstrategico = new EjeEstrategico
                {
                    idEje = row["idEje"].ToString(),
                    nombreEjeEstrategico = row["nombreEjeEstrategico"].ToString()
                };

                ejesEstrategicos.Add(ejeEstrategico);
            }

            return View(ejesEstrategicos);
        }

        // GET: EjeEstrategicos/Details/5
        public ActionResult Details(string id)
        {
            var dataTable = logicaEjeEstrategico.ObtenerEjeEstrategicoPorId(id);
            if (dataTable.Rows.Count == 0)
            {
                return HttpNotFound();
            }

            var row = dataTable.Rows[0];
            EjeEstrategico ejeEstrategico = new EjeEstrategico
            {
                idEje = row["idEje"].ToString(),
                nombreEjeEstrategico = row["nombreEjeEstrategico"].ToString()
            };

            return View(ejeEstrategico);
        }

        // GET: EjeEstrategicos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EjeEstrategicos/Create
        [HttpPost]
        public ActionResult Create(EjeEstrategico ejeEstrategico)
        {
            try
            {
                logicaEjeEstrategico.AgregarEjeEstrategico(ejeEstrategico.idEje, ejeEstrategico.nombreEjeEstrategico);

                return RedirectToAction("Estrategia");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(ejeEstrategico);
            }
        }

        // GET: EjeEstrategicos/Edit/5
        public ActionResult Edit(string id)
        {
            var dataTable = logicaEjeEstrategico.ObtenerEjeEstrategicoPorId(id);
            if (dataTable.Rows.Count == 0)
            {
                return HttpNotFound();
            }

            var row = dataTable.Rows[0];
            EjeEstrategico ejeEstrategico = new EjeEstrategico
            {
                idEje = row["idEje"].ToString(),
                nombreEjeEstrategico = row["nombreEjeEstrategico"].ToString()
            };

            return View(ejeEstrategico);
        }

        // POST: EjeEstrategicos/Edit/5
        [HttpPost]
        public ActionResult Edit(EjeEstrategico ejeEstrategico)
        {
            try
            {
                logicaEjeEstrategico.EditarEjeEstrategico(ejeEstrategico.idEje, ejeEstrategico.nombreEjeEstrategico);

                return RedirectToAction("Estrategia");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(ejeEstrategico);
            }
        }

        // GET: EjeEstrategicos/Delete/5
        public ActionResult Delete(string id)
        {
            var dataTable = logicaEjeEstrategico.ObtenerEjeEstrategicoPorId(id);
            if (dataTable.Rows.Count == 0)
            {
                return HttpNotFound();
            }

            var row = dataTable.Rows[0];
            EjeEstrategico ejeEstrategico = new EjeEstrategico
            {
                idEje = row["idEje"].ToString(),
                nombreEjeEstrategico = row["nombreEjeEstrategico"].ToString()
            };

            return View(ejeEstrategico);
        }

        // POST: EjeEstrategicos/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                logicaEjeEstrategico.EliminarEjeEstrategico(id);

                return RedirectToAction("Estrategia");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }
        }
    }
}
