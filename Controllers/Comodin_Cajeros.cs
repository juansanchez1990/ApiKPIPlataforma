namespace ApiPlatformKPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Comodin_Cajeros
    {
        public int id { get; set; }

        [StringLength(50)]
        public string Comodin { get; set; }

        public string Comentario { get; set; }

        [StringLength(50)]
        public string Usuario { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fecha { get; set; }

        public int? Tienda { get; set; }

        [StringLength(50)]
        public string Intervalo { get; set; }
    }
}
