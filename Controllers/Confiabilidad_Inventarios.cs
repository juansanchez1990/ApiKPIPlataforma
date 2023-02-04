namespace ApiPlatformKPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Confiabilidad_Inventarios
    {
        public int id { get; set; }

        public decimal? Valor_Real_Contado { get; set; }

        public decimal? Valor_Teorico { get; set; }

        public int? Referencias_Contadas { get; set; }

        public int? Referencias_S_Diferencias { get; set; }

        public int? Tienda { get; set; }

        public DateTime? Fecha { get; set; }

        public int? Tipo { get; set; }

        public int? Semana { get; set; }

        [StringLength(50)]
        public string Codigo_Categoria { get; set; }

        [StringLength(500)]
        public string Categoria { get; set; }
    }
}
