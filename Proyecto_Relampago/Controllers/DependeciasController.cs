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

    public class DependenciaController : Controller
    {
        private Dependencia_Logica logicaDependencia = new Dependencia_Logica();

        // GET: Dependencias
        public ActionResult Dependencias()
        {
            DataTable dtDependencias = logicaDependencia.ObtenerTodasLasDependencias();
            List<Dependecia> dependencias = new List<Dependecia>();

            foreach (DataRow row in dtDependencias.Rows)
            {
                Dependecia dependencia = new Dependecia
                {
                    idDependencia = row["idDependencia"].ToString(),
                    nombreDependencia = row["nombreDependencia"].ToString()
                };

                dependencias.Add(dependencia);
            }

            return View(dependencias);
        }

    

        public ActionResult DependenciasFiltro(string idDependencia = null, string nombreDependencia = null)
        {
            DataTable dtDependencias = logicaDependencia.FiltrarDependencias();
            List<Dependecia> dependencias = new List<Dependecia>();

            foreach (DataRow row in dtDependencias.Rows)
            {
                Dependecia dependencia = new Dependecia
                {
                    idDependencia = row["idDependencia"].ToString(),
                    nombreDependencia = row["nombreDependencia"].ToString()
                };

                dependencias.Add(dependencia);
            }

            return View(dependencias);
        }





        // GET: Dependencias/Details/5
        public ActionResult Details(string id)
            {
                var dataTable = logicaDependencia.ObtenerDependenciaPorId(id);
                if (dataTable.Rows.Count == 0)
                {
                    return HttpNotFound();
                }

                var row = dataTable.Rows[0];
                Dependecia dependencia = new Dependecia
                {
                    idDependencia = row["idDependencia"].ToString(),
                    nombreDependencia = row["nombreDependencia"].ToString()
                };

                return View(dependencia);
            }

            // GET: Dependencias/Create
            public ActionResult Create()
            {
                return View();
            }

            // POST: Dependencias/Create
            [HttpPost]
            public ActionResult Create(Dependecia dependencia)
            {
                try
                {
                    logicaDependencia.AgregarDependencia(dependencia.idDependencia, dependencia.nombreDependencia);

                    return RedirectToAction("Dependencias");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                    return View(dependencia);
                }
            }

            // GET: Dependencias/Edit/5
            public ActionResult Edit(string id)
            {
                var dataTable = logicaDependencia.ObtenerDependenciaPorId(id);
                if (dataTable.Rows.Count == 0)
                {
                    return HttpNotFound();
                }

                var row = dataTable.Rows[0];
                Dependecia dependencia = new Dependecia
                {
                    idDependencia = row["idDependencia"].ToString(),
                    nombreDependencia = row["nombreDependencia"].ToString()
                };

                return View(dependencia);
            }

            // POST: Dependencias/Edit/5
            [HttpPost]
            public ActionResult Edit(Dependecia dependencia)
            {
                try
                {
                    logicaDependencia.EditarDependencia(dependencia.idDependencia, dependencia.nombreDependencia);

                    return RedirectToAction("Dependencias");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                    return View(dependencia);
                }
            }

            // GET: Dependencias/Delete/5
            public ActionResult Delete(string id)
            {
                var dataTable = logicaDependencia.ObtenerDependenciaPorId(id);
                if (dataTable.Rows.Count == 0)
                {
                    return HttpNotFound();
                }

                var row = dataTable.Rows[0];
                Dependecia dependencia = new Dependecia
                {
                    idDependencia = row["idDependencia"].ToString(),
                    nombreDependencia = row["nombreDependencia"].ToString()
                };

                return View(dependencia);
            }

            // POST: Dependencias/Delete/5
            [HttpPost]
            public ActionResult Delete(string id, FormCollection collection)
            {
                try
                {
                    logicaDependencia.EliminarDependencia(id);

                    return RedirectToAction("Dependencias");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                    return View();
                }
            }
        }
    }
