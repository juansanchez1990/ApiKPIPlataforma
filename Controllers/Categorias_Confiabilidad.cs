namespace ApiPlatformKPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Categorias_Confiabilidad
    {
        public int id { get; set; }

        [StringLength(50)]
        public string Categoria { get; set; }

        public int Tienda { get; set; }

        public int Semana { get; set; }

        public int Año { get; set; }
    }
}
