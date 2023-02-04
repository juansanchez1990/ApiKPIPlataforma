namespace ApiPlatformKPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KPI_ReporteCajeros
    {
        public int id { get; set; }

        public int? Tienda { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fecha { get; set; }

        public int? NumSemana { get; set; }

        [StringLength(50)]
        public string Semana { get; set; }

        public int? Transacciones { get; set; }

        public int? Caja { get; set; }

        public string Cajero { get; set; }

        public double? Ventas { get; set; }

        public double? TicketPromedio { get; set; }

        public int? HorasTrabajadas { get; set; }
    }
}
