using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Relampago.Models
{
    public class Procedimiento
    {
        public string IdEje { get; set; }
        public string IdArea { get; set; }
        public string IdDependencia { get; set; }
        public string TipoProcedimiento { get; set; }
        public string Estado { get; set; }
        public string Teletrabajado { get; set; }
        public string IdMacroproceso { get; set; }
        public string IdEjeEstrategico { get; set; }
        public string TipoDocumento { get; set; }
        public string NombreProcedimiento { get; set; }
        public string ApoyoTecnologico { get; set; }
        public string AnioActualizacion { get; set; }
    }
}