namespace ApiPlatformKPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KPI_ReporteDeli
    {
        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fecha { get; set; }

        [StringLength(50)]
        public string Dia { get; set; }

        [StringLength(50)]
        public string NombreCategoria { get; set; }

        [StringLength(50)]
        public string Intervalo { get; set; }

        public int? TotalProductos { get; set; }

        public double? TicketPromedio { get; set; }

        public double? TiempoTransaccion { get; set; }

        public int? CantidadPersonas { get; set; }

        public int? Tienda { get; set; }
    }
}
