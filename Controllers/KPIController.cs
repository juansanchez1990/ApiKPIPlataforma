
using ApiPlatformKPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiPlatformKPI.Controllers
{
    public class KPIController : ApiController
    {
        ModelKPI KPIData = new ModelKPI();

        [HttpGet]
        [Route("api/kpiPlatform/getVelocidadCajeros/{idStore}/{idCajero}")]
        public IHttpActionResult getVelocidadCajeros(int idStore, int idCajero)
        {
            var DataCajero = KPIData.Database.SqlQuery<VelocidadCajeros>("exec KPI_Medicion_Cajeros" + " " + idStore+"," + idCajero);

            return Ok(DataCajero);
        }

        [HttpGet]
        [Route("api/kpiPlatform/IniciarSesion/{usuario}/{password}")]
        public IHttpActionResult IniciarSesion(string usuario, string password)
        {

            var userAll = KPIData.Usuarios_KPI.FirstOrDefault(i => i.Usuario == usuario && i.Contrasenia == password);
            if (userAll == null)
            {
                return BadRequest("Credenciales Incorrectas");
            }
            else
            {

              
                return Ok(userAll);
            }

        }

        [HttpPost]
        [Route("api/kpiPlatform/RegitrarComodines")]
        public IHttpActionResult RegitrarComodines(List<Comodin_Cajeros> nuevoComodin)
        {

            foreach (Comodin_Cajeros comodinCajero in nuevoComodin)
            {
                Comodin_Cajeros comodin = new Comodin_Cajeros();
          
                comodin.Comodin = (comodinCajero.Comodin=="") ?"S/C": comodinCajero.Comodin.ToUpper();
                comodin.Comentario =(comodinCajero.Comentario=="") ? "N/C":comodinCajero.Comentario;
                comodin.Fecha = DateTime.Today;
                comodin.Intervalo = comodinCajero.Intervalo;
                comodin.Tienda = comodinCajero.Tienda;
                comodin.Usuario = comodinCajero.Usuario;
                KPIData.Comodin_Cajeros.Add(comodin);

            }
            KPIData.SaveChanges();

            return Ok();
        }

        [HttpPost]
        [Route("api/kpiPlatform/RegistrarLog")]
        public IHttpActionResult RegistrarLogUsuarios(Log_Usuarios usuarioLog)
        {
            Log_Usuarios logUser = new Log_Usuarios();

            logUser.Usuario = usuarioLog.Usuario;
            logUser.Tienda = usuarioLog.Tienda;
            logUser.Id_KPI = usuarioLog.Id_KPI;
            logUser.FechaIngreso = DateTime.Now;

            KPIData.Log_Usuarios.Add(logUser);
            KPIData.SaveChanges();

            return Ok();
        }
    }
    }
