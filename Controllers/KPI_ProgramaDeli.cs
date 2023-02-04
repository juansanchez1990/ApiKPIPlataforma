namespace ApiPlatformKPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KPI_ProgramaDeli
    {
        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fecha { get; set; }

        [StringLength(50)]
        public string Dia { get; set; }

        public int? NumDia { get; set; }

        public int? Tienda { get; set; }

        public int? Semana { get; set; }

        public string Codigo { get; set; }

        public string Producto { get; set; }

        public double? Cantidad { get; set; }

        [StringLength(50)]
        public string Tipo { get; set; }

        [StringLength(50)]
        public string TipoSemana { get; set; }
    }
}
