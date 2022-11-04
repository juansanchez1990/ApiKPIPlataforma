using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiPlatformKPI.Models
{
    public class VelocidadCajeros
    {

        public string Semana { get; set; }

        public int Transacciones { get; set; }

        public int Caja { get; set; }

        public int Tienda { get; set; }

        public int IdCajero { get; set; }

        public string Cajero { get; set; }

        public int Periodo_Base { get; set; }

        public double Ventas { get; set; }

        public double TicketPromedio { get; set; }

        public string Intervalo { get; set; }

        public double CantidadProductos { get; set; }

        public int NumSemana { get; set; }

        public DateTime Fecha { get; set; }
    }
}