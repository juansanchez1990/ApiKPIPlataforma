namespace ApiPlatformKPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Marcajes_Impulsadores
    {
        public int id { get; set; }

        public string Nombre { get; set; }

        [StringLength(50)]
        public string Hora { get; set; }

        [StringLength(50)]
        public string Dia { get; set; }

        public int? Tienda { get; set; }

        [StringLength(50)]
        public string Tipo_Marcaje { get; set; }

        public string Proveedor { get; set; }
    }
}
