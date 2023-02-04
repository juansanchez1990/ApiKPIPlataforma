namespace ApiPlatformKPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Top500Productos
    {
        public int id { get; set; }

        [StringLength(50)]
        public string Producto { get; set; }

        [StringLength(50)]
        public string Codigo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaActualizacion { get; set; }

        public int? Tienda { get; set; }

        public int? ItemID { get; set; }

        public int? TipoTop { get; set; }
    }
}
