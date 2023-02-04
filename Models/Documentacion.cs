using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiPlatformKPI.Models
{
    public class Documentacion
    {
        public int id { get; set; }

        public int OrderID { get; set; }
        public string Documento { get; set; }

        public string Link { get; set; }

        public string Tipo { get; set; }

        public string KPI { get; set; }

        public int id_KPI { get; set; }
    }
}