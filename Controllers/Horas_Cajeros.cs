namespace ApiPlatformKPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Horas_Cajeros
    {
        public int id { get; set; }

        public double? Cantidad_Productos { get; set; }

        public int? Id_Cajero { get; set; }

        public int? Tienda { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fecha { get; set; }

        public int? Horas { get; set; }

        [StringLength(50)]
        public string Number_Cajero { get; set; }
    }
}
