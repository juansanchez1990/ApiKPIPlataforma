namespace ApiPlatformKPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KPI_Nombres_Reportes
    {
        public int id { get; set; }

        public string Nombre_KPI { get; set; }

        public string Imagen { get; set; }
    }
}
