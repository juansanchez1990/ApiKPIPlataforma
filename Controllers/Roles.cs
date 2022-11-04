namespace ApiPlatformKPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Roles
    {
        public int id { get; set; }

        [StringLength(50)]
        public string Rol { get; set; }

        public int? DepartamentoId { get; set; }

        public bool? Activo { get; set; }
    }
}
