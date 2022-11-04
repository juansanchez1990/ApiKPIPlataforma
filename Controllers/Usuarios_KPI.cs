namespace ApiPlatformKPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Usuarios_KPI
    {
        public int id { get; set; }

        public string Nombre_Completo { get; set; }

        [StringLength(100)]
        public string Usuario { get; set; }

        public string Contrasenia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaRegistro { get; set; }

        public int? Rol { get; set; }

        public string Correo { get; set; }

        public string Celular { get; set; }

        public string Foto { get; set; }

        public bool? Activo { get; set; }

        public int? Departamento { get; set; }

        public int? Tienda { get; set; }
    }
}
