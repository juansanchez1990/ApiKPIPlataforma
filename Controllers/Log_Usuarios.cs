namespace ApiPlatformKPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Log_Usuarios
    {
        public int id { get; set; }

        [StringLength(100)]
        public string Usuario { get; set; }

        public int? Id_KPI { get; set; }

        public DateTime? FechaIngreso { get; set; }

        public int? Tienda { get; set; }
    }
}
