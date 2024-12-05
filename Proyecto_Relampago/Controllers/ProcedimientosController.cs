using Logica;
using Proyecto_Relampago.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Mvc;

namespace Proyecto_Relampago.Controllers
{
    public class ProcedimientosController : Controller
    {
        private Procedimientos_Logica logicaProcedimientos = new Procedimientos_Logica();

        // GET: Procedimientos
        public ActionResult Index()
        {
            DataTable dtProcedimientos = logicaProcedimientos.ObtenerTodosLosProcedimientos();
            List<Procedimiento> procedimientos = new List<Procedimiento>();

            foreach (DataRow row in dtProcedimientos.Rows)
            {
                Procedimiento procedimiento = new Procedimiento
                {
                    IdEje = row["idEje"].ToString(),
                    IdArea = row["idArea"].ToString(),
                    IdDependencia = row["idDependencia"].ToString(),
                    TipoProcedimiento = row["tipoProcedimiento"].ToString(),
                    Estado = row["estado"].ToString(),
                    Teletrabajado = row["teletrabajado"].ToString(),
                    IdMacroproceso = row["idMacroproceso"].ToString(),
                    IdEjeEstrategico = row["idEjeEstrategico"].ToString(),
                    TipoDocumento = row["tipoDocumento"].ToString(),
                    NombreProcedimiento = row["nombreProcedimiento"].ToString(),
                    ApoyoTecnologico = row["apoyoTecnologico"].ToString(),
                    AnioActualizacion = row["anioActualizacion"].ToString()
                };

                procedimientos.Add(procedimiento);
            }

            return View(procedimientos);
        }

        public ActionResult IndexFiltro(string idEje = null, string idArea = null, string tipoProcedimiento = null,
            string estado = null, string anioActualizacion = null)
        {
            DataTable dtProcedimientos = logicaProcedimientos.ObtenerTodosLosProcedimientos();
            List<Procedimiento> procedimientos = new List<Procedimiento>();

            foreach (DataRow row in dtProcedimientos.Rows)
            {
                Procedimiento procedimiento = new Procedimiento
                {
                    IdEje = row["idEje"].ToString(),
                    IdArea = row["idArea"].ToString(),
                    IdDependencia = row["idDependencia"].ToString(),
                    TipoProcedimiento = row["tipoProcedimiento"].ToString(),
                    Estado = row["estado"].ToString(),
                    Teletrabajado = row["teletrabajado"].ToString(),
                    IdMacroproceso = row["idMacroproceso"].ToString(),
                    IdEjeEstrategico = row["idEjeEstrategico"].ToString(),
                    TipoDocumento = row["tipoDocumento"].ToString(),
                    NombreProcedimiento = row["nombreProcedimiento"].ToString(),
                    ApoyoTecnologico = row["apoyoTecnologico"].ToString(),
                    AnioActualizacion = row["anioActualizacion"].ToString()
                };

                procedimientos.Add(procedimiento);
            }

            return View(procedimientos);
        }

        // GET: Procedimientos/Details/5
        public ActionResult Details(string id)
        {
            var dataTable = logicaProcedimientos.ObtenerProcedimientoPorId(id);
            if (dataTable.Rows.Count == 0)
            {
                return HttpNotFound();
            }

            var row = dataTable.Rows[0];
            Procedimiento procedimiento = new Procedimiento
            {
                IdEje = row["idEje"].ToString(),
                IdArea = row["idArea"].ToString(),
                IdDependencia = row["idDependencia"].ToString(),
                TipoProcedimiento = row["tipoProcedimiento"].ToString(),
                Estado = row["estado"].ToString(),
                Teletrabajado = row["teletrabajado"].ToString(),
                IdMacroproceso = row["idMacroproceso"].ToString(),
                IdEjeEstrategico = row["idEjeEstrategico"].ToString(),
                TipoDocumento = row["tipoDocumento"].ToString(),
                NombreProcedimiento = row["nombreProcedimiento"].ToString(),
                ApoyoTecnologico = row["apoyoTecnologico"].ToString(),
                AnioActualizacion = row["anioActualizacion"].ToString()
            };

            return View(procedimiento);
        }

        // GET: Procedimientos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Procedimientos/Create
        [HttpPost]
        public ActionResult Create(Procedimiento procedimiento)
        {
            try
            {
                logicaProcedimientos.AgregarProcedimiento(
                    procedimiento.IdEje,
                    procedimiento.IdArea,
                    procedimiento.IdDependencia,
                    procedimiento.TipoProcedimiento,
                    procedimiento.Estado,
                    procedimiento.Teletrabajado,
                    procedimiento.IdMacroproceso,
                    procedimiento.IdEjeEstrategico,
                    procedimiento.TipoDocumento,
                    procedimiento.NombreProcedimiento,
                    procedimiento.ApoyoTecnologico,
                    procedimiento.AnioActualizacion
                );

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(procedimiento);
            }
        }

        // GET: Procedimientos/Edit/5
        public ActionResult Edit(string id)
        {
            var dataTable = logicaProcedimientos.ObtenerProcedimientoPorId(id);
            if (dataTable.Rows.Count == 0)
            {
                return HttpNotFound();
            }

            var row = dataTable.Rows[0];
            Procedimiento procedimiento = new Procedimiento
            {
                IdEje = row["idEje"].ToString(),
                IdArea = row["idArea"].ToString(),
                IdDependencia = row["idDependencia"].ToString(),
                TipoProcedimiento = row["tipoProcedimiento"].ToString(),
                Estado = row["estado"].ToString(),
                Teletrabajado = row["teletrabajado"].ToString(),
                IdMacroproceso = row["idMacroproceso"].ToString(),
                IdEjeEstrategico = row["idEjeEstrategico"].ToString(),
                TipoDocumento = row["tipoDocumento"].ToString(),
                NombreProcedimiento = row["nombreProcedimiento"].ToString(),
                ApoyoTecnologico = row["apoyoTecnologico"].ToString(),
                AnioActualizacion = row["anioActualizacion"].ToString()
            };

            return View(procedimiento);
        }

        // POST: Procedimientos/Edit/5
        [HttpPost]
        public ActionResult Edit(Procedimiento procedimiento)
        {
            try
            {
                logicaProcedimientos.EditarProcedimiento(
                    procedimiento.IdEje,
                    procedimiento.IdArea,
                    procedimiento.IdDependencia,
                    procedimiento.TipoProcedimiento,
                    procedimiento.Estado,
                    procedimiento.Teletrabajado,
                    procedimiento.IdMacroproceso,
                    procedimiento.IdEjeEstrategico,
                    procedimiento.TipoDocumento,
                    procedimiento.NombreProcedimiento,
                    procedimiento.ApoyoTecnologico,
                    procedimiento.AnioActualizacion
                );

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(procedimiento);
            }
        }

        // GET: Procedimientos/Delete/5
        public ActionResult Delete(string id)
        {
            var dataTable = logicaProcedimientos.ObtenerProcedimientoPorId(id);
            if (dataTable.Rows.Count == 0)
            {
                return HttpNotFound();
            }

            var row = dataTable.Rows[0];
            Procedimiento procedimiento = new Procedimiento
            {
                IdEje = row["idEje"].ToString(),
                IdArea = row["idArea"].ToString(),
                IdDependencia = row["idDependencia"].ToString(),
                TipoProcedimiento = row["tipoProcedimiento"].ToString(),
                Estado = row["estado"].ToString(),
                Teletrabajado = row["teletrabajado"].ToString(),
                IdMacroproceso = row["idMacroproceso"].ToString(),
                IdEjeEstrategico = row["idEjeEstrategico"].ToString(),
                TipoDocumento = row["tipoDocumento"].ToString(),
                NombreProcedimiento = row["nombreProcedimiento"].ToString(),
                ApoyoTecnologico = row["apoyoTecnologico"].ToString(),
                AnioActualizacion = row["anioActualizacion"].ToString()
            };

            return View(procedimiento);
        }

        // POST: Procedimientos/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                logicaProcedimientos.EliminarProcedimiento(id);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }
        }
    }
}
