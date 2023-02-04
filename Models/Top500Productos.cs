using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPlatformKPI.Models
{
    public class Top500Productos
    {
        [Key]
        public int id { get; set; }

        [StringLength(50)]
        public string Producto { get; set; }

        [StringLength(50)]
        public string Codigo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaActualizacion { get; set; }

        public int? Tienda { get; set; }

        public int? ItemID { get; set; }

        public int? TipoTop { get; set; }

    }
}