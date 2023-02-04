namespace ApiPlatformKPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Margen_Categorias
    {
        public int id { get; set; }

        [StringLength(50)]
        public string Codigo_Categoria { get; set; }

        public int? Codigo_Depto { get; set; }

        public string Categoria_Nueva { get; set; }

        public double? Minimo_Nacional { get; set; }

        public double? Maximo_Nacional { get; set; }

        public double? Minimo_Importado { get; set; }

        public double? Maximo_Importado { get; set; }
    }
}
