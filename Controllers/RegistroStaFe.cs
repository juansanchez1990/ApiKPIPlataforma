namespace ApiPlatformKPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RegistroStaFe")]
    public partial class RegistroStaFe
    {
        public int id { get; set; }

        public string Producto { get; set; }

        public string Responsable { get; set; }

        public string Motivo { get; set; }

        public int? Cantidad_Aceptada { get; set; }

        public int? Cantidad_Rechazada { get; set; }

        public DateTime? Fecha { get; set; }

        public string Evidencia { get; set; }
    }
}
