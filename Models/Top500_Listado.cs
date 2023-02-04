using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiPlatformKPI.Models
{
    public class Top500_Listado
    {
       
        public double Venta { get; set; }

        public double CantidadSistema { get; set; }

    
        public string Producto { get; set; }

        public int Tienda { get; set; }

       
        public string Departamento { get; set; }

      
        public string Categoria { get; set; }

       
        

        
        public string Codigo_Producto { get; set; }

    }
}