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
    public class AreaController : Controller
    {
        private Area_Logica logicaArea = new Area_Logica();

        // GET: Areas
        public ActionResult Areas()
        {
            DataTable dtAreas = logicaArea.ObtenerTodasLasAreas();
            List<Area> areas = new List<Area>();

            foreach (DataRow row in dtAreas.Rows)
            {
                Area area = new Area
                {
                    IdArea = row["IdArea"].ToString(),
                    NombreArea = row["NombreArea"].ToString()
                };

                areas.Add(area);
            }

            return View(areas);
        }

        // Método para filtrar áreas con parámetros opcionales
        public ActionResult AreasFiltro(string idArea = null, string nombreArea = null)
        {
            // Llamamos al método FiltrarAreas de la lógica de negocio
            DataTable dtAreas = logicaArea.FiltrarAreas(idArea, nombreArea);
            List<Area> areas = new List<Area>();

            foreach (DataRow row in dtAreas.Rows)
            {
                Area area = new Area
                {
                    IdArea = row["IdArea"].ToString(),
                    NombreArea = row["NombreArea"].ToString()
                };

                areas.Add(area);
            }

            return View(areas);
        }


        // GET: Areas/Details/5
        public ActionResult Details(string id)
        {
            var dataTable = logicaArea.ObtenerAreaPorId(id);
            if (dataTable.Rows.Count == 0)
            {
                return HttpNotFound();
            }

            var row = dataTable.Rows[0];
            Area area = new Area
            {
                IdArea = row["IdArea"].ToString(),
                NombreArea = row["NombreArea"].ToString()
            };

            return View(area);
        }

        // GET: Areas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Areas/Create
        [HttpPost]
        public ActionResult Create(Area area)
        {
            try
            {
                logicaArea.AgregarArea(area.IdArea, area.NombreArea);

                return RedirectToAction("Areas");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(area);
            }
        }

        // GET: Areas/Edit/5
        public ActionResult Edit(string id)
        {
            var dataTable = logicaArea.ObtenerAreaPorId(id);
            if (dataTable.Rows.Count == 0)
            {
                return HttpNotFound();
            }

            var row = dataTable.Rows[0];
            Area area = new Area
            {
                IdArea = row["IdArea"].ToString(),
                NombreArea = row["NombreArea"].ToString()
            };

            return View(area);
        }

        // POST: Areas/Edit/5
        [HttpPost]
        public ActionResult Edit(Area area)
        {
            try
            {
                logicaArea.EditarArea(area.IdArea, area.NombreArea);

                return RedirectToAction("Areas");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(area);
            }
        }

        // GET: Areas/Delete/5
        public ActionResult Delete(string id)
        {
            var dataTable = logicaArea.ObtenerAreaPorId(id);
            if (dataTable.Rows.Count == 0)
            {
                return HttpNotFound();
            }

            var row = dataTable.Rows[0];
            Area area = new Area
            {
                IdArea = row["IdArea"].ToString(),
                NombreArea = row["NombreArea"].ToString()
            };

            return View(area);
        }



        // POST: Areas/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                logicaArea.EliminarArea(id);

                return RedirectToAction("Areas");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }
        }
    }
}
