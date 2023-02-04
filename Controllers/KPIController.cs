
using ApiPlatformKPI.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiPlatformKPI.Controllers
{
    public class KPIController : ApiController
    {
      
    ModelKPI KPIData = new ModelKPI();
    HQData ModelHQ = new HQData();
        [HttpGet]
        [Route("api/kpiPlatform/getVelocidadCajeros/{idStore}/{idCajero}")]
        public IHttpActionResult getVelocidadCajeros(int idStore, int idCajero)
        {
            var DataCajero = KPIData.Database.SqlQuery<VelocidadCajeros>("exec KPI_Medicion_Cajeros" + " " + idStore+"," + idCajero);

            return Ok(DataCajero);
        }


        [HttpGet]
        [Route("api/kpiPlatform/getCategorias")]
        public IHttpActionResult getCategorias()
        {
            var Categorias = ModelHQ.Database.SqlQuery<Category>("select * from Category where [Name] not like '(NO USAR)%' order by [Name] asc");

            return Ok(Categorias);
        }

        [HttpGet]
        [Route("api/kpiPlatform/getDocumentacion")]
        public IHttpActionResult getDocumentacion()
        {
            var Documentacion = KPIData.Database.SqlQuery<Documentacion>("select * from Documentacion_KPI");

            return Ok(Documentacion);
        }

        [HttpGet]
        [Route("api/kpiPlatform/getMargenCategorias")]
        public IHttpActionResult getMargenCategorias()
        {
            var CategoriasMargen =
                KPIData.Margen_Categorias.OrderBy(c=>c.Categoria_Nueva).ToList();

            return Ok(CategoriasMargen);
        }

        [HttpGet]
        [Route("api/kpiPlatform/getDepartamentos")]
        public IHttpActionResult getDepartamentos()
        {
          
            var CategoriasMargen = ModelHQ.Database.SqlQuery<Department>
          ("select * from Department");
            return Ok(CategoriasMargen);
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
        [Route("api/kpiPlatform/RegitrarComodines/{Tienda}")]
        public IHttpActionResult RegitrarComodines(List<Comodin_Cajeros> nuevoComodin,int Tienda)
        {
            var Data = KPIData.Comodin_Cajeros.FirstOrDefault(c => c.Fecha == DateTime.Today && c.Tienda == Tienda);
            if (Data == null)
            {
                foreach (Comodin_Cajeros comodinCajero in nuevoComodin)
                {
                    Comodin_Cajeros comodin = new Comodin_Cajeros();

                    comodin.Comodin = (comodinCajero.Comodin == "") ? "S/C" : comodinCajero.Comodin.ToUpper();
                    comodin.Comentario = (comodinCajero.Comentario == "") ? "N/C" : comodinCajero.Comentario;
                    comodin.Fecha = DateTime.Today;
                    //comodin.Fecha = DateTime.Today.AddDays(-7);
                    comodin.Intervalo = comodinCajero.Intervalo;
                    comodin.Tienda = Tienda;
                    //comodin.Tienda = 3;
                    comodin.Usuario = comodinCajero.Usuario;
                    KPIData.Comodin_Cajeros.Add(comodin);

                }
                KPIData.SaveChanges();

            }

            else
            {
                return BadRequest("Ya hay un registro de Auxiliares para esta tienda con la fecha de hoy");
            }
         

            return Ok();
        }

        [HttpPost]
        [Route("api/kpiPlatform/RegitrarAuxiliarDeli/{Tienda}")]
        public IHttpActionResult RegitrarAuxiliarDeli(List<Auxiliar_Deli> nuevoAuxiliar, int Tienda)
        {
            var Data = KPIData.Auxiliar_Deli.FirstOrDefault(c => c.Fecha == DateTime.Today && c.Tienda == Tienda);
            if (Data == null)
            {
                foreach (Auxiliar_Deli auxDeli in nuevoAuxiliar)
                {
                    Auxiliar_Deli comodin = new Auxiliar_Deli();

                    comodin.Comodin = (auxDeli.Comodin == "") ? "S/C" : auxDeli.Comodin.ToUpper();
                    comodin.Comentario = (auxDeli.Comentario == "") ? "N/C" : auxDeli.Comentario;
                    comodin.Fecha = DateTime.Today;
                    //comodin.Fecha = DateTime.Today.AddDays(-2);
                    comodin.Intervalo = auxDeli.Intervalo;
                    comodin.Tienda = Tienda;
                    //comodin.Tienda = 4;
                    comodin.Usuario = auxDeli.Usuario;
                    KPIData.Auxiliar_Deli.Add(comodin);

                }
                KPIData.SaveChanges();
            }
            else
            {
                return BadRequest("Ya hay un registro de Auxiliares Deli para esta tienda con la fecha de hoy");
            }
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

        [HttpPost]
        [Route("api/kpiPlatform/RegistrarCategoriasConfiabilidad")]
        public IHttpActionResult RegistrarCategoriasConfiabilidad(List<Categorias_Confiabilidad> categoriasConfiab)
        {
            foreach (Categorias_Confiabilidad nuevo in categoriasConfiab)
            {
                Categorias_Confiabilidad categoria = new Categorias_Confiabilidad();
                categoria.Categoria = nuevo.Categoria;
                categoria.Año = DateTime.Now.Year;
                categoria.Semana = nuevo.Semana;
                categoria.Tienda = nuevo.Tienda;
                KPIData.Categorias_Confiabilidad.Add(categoria);
                KPIData.SaveChanges();

            }


           
            return Ok();

        }



        [HttpPost]
        [Route("api/kpiPlatform/RegistrarConfiabilidad")]
        public IHttpActionResult RegistrarConfiabilidad(List<Confiabilidad_Inventarios> RegistroConfiabilidad)
        {
            foreach (Confiabilidad_Inventarios nuevo in RegistroConfiabilidad)
            {
                var NombreCategoria = "";
                if (nuevo.Codigo_Categoria == "")
                {
                    NombreCategoria = "Sin Categoria";
                }
                else
                {
                 NombreCategoria = ModelHQ.Category.FirstOrDefault(c => c.Code == nuevo.Codigo_Categoria).Name;

                }
                
                Confiabilidad_Inventarios ConfiabRegistro = new Confiabilidad_Inventarios();

                ConfiabRegistro.Valor_Real_Contado = nuevo.Valor_Real_Contado;
                ConfiabRegistro.Valor_Teorico = nuevo.Valor_Teorico;
                ConfiabRegistro.Referencias_Contadas = nuevo.Referencias_Contadas;
                ConfiabRegistro.Referencias_S_Diferencias = nuevo.Referencias_S_Diferencias;
                ConfiabRegistro.Tienda = nuevo.Tienda;
                ConfiabRegistro.Tipo = nuevo.Tipo;
                ConfiabRegistro.Semana = nuevo.Semana;
                ConfiabRegistro.Codigo_Categoria = (nuevo.Codigo_Categoria == "") ? "S/C" : nuevo.Codigo_Categoria;
                ConfiabRegistro.Categoria = NombreCategoria;
                ConfiabRegistro.Fecha = DateTime.Now;

                KPIData.Confiabilidad_Inventarios.Add(ConfiabRegistro);
                KPIData.SaveChanges();
            }

            return Ok();
        }

        [HttpGet]
        [Route("api/kpiPlatform/ObtenerRegistroStaFe")]
        public IHttpActionResult getRegistroStaFe()
        {
            var Registros = KPIData.Database.SqlQuery<RegistroStaFe>
            ("select * from RegistroStaFe");

            return Ok(Registros);
        }


        [HttpPost]
        [Route("api/kpiPlatform/RegistroStaFe")]
        public IHttpActionResult RegistroStaFe(RegistroStaFe registro)
        {
            
                 RegistroStaFe registroStaFe = new RegistroStaFe();
                 registroStaFe.Producto = registro.Producto;
                 registroStaFe.Motivo = registro.Motivo;
                 registroStaFe.Evidencia = registro.Evidencia;
                 registroStaFe.Cantidad_Rechazada = registro.Cantidad_Rechazada;
                 registroStaFe.Cantidad_Aceptada = registro.Cantidad_Aceptada;
                 registroStaFe.Fecha = DateTime.Today;
                 registroStaFe.Responsable = registro.Responsable;

            KPIData.RegistroStaFe.Add(registroStaFe);
                KPIData.SaveChanges();

            



            return Ok();

        }


   
        







        [HttpPost]
        [Route("api/kpiPlatform/RegistrarTop/{idStore}/{idMedicion}")]
        public IHttpActionResult RegistrarTop(List<string> nuevosProductosTop,int idStore,int idMedicion)
        {
            if (idMedicion == 1)
            {
                KPIData.Database.ExecuteSqlCommand("delete from Top500Productos where Tienda=" + idStore);
                //KPIData.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Top500Productos', RESEED, 0)");
                //KPIData.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Top500Productos', RESEED, 0)");

                foreach (string nuevo in nuevosProductosTop)
                {
                    try
                    {
                        var Codigo = ModelHQ.Item.FirstOrDefault(i => i.ItemLookupCode == nuevo).ItemLookupCode;
                        var Producto = ModelHQ.Item.FirstOrDefault(i => i.ItemLookupCode == nuevo).Description;
                        var ItemID = ModelHQ.Item.FirstOrDefault(i => i.ItemLookupCode == nuevo).ID;
                        Top500Productos topProductos = new Top500Productos();
                        topProductos.Codigo = Codigo;
                        topProductos.Producto = Producto;
                        topProductos.Tienda = idStore;
                        topProductos.ItemID = ItemID;
                        topProductos.FechaActualizacion = DateTime.Now;
                        topProductos.TipoTop = idMedicion;
                        KPIData.Top500Productos.Add(topProductos);
                    }
                    catch
                    {
                        return BadRequest("El codigo" + " " + nuevo + " " + "no existe, por favor verifiquelo y vuelva a cargar la lista");
                    }
                }

              
                }

            if (idMedicion == 2)
            {
                KPIData.Database.ExecuteSqlCommand("delete from Top300Productos where Tienda=" + idStore);
                //KPIData.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Top500Productos', RESEED, 0)");
                //KPIData.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Top500Productos', RESEED, 0)");

                foreach (string nuevo in nuevosProductosTop)
                {
                    try
                    {
                        var Codigo = ModelHQ.Item.FirstOrDefault(i => i.ItemLookupCode == nuevo).ItemLookupCode;
                        var Producto = ModelHQ.Item.FirstOrDefault(i => i.ItemLookupCode == nuevo).Description;
                        var ItemID = ModelHQ.Item.FirstOrDefault(i => i.ItemLookupCode == nuevo).ID;
                        Top300Productos topProductos = new Top300Productos();
                        topProductos.Codigo = Codigo;
                        topProductos.Producto = Producto;
                        topProductos.Tienda = idStore;
                        topProductos.ItemID = ItemID;
                        topProductos.FechaActualizacion = DateTime.Now;
                        topProductos.TipoTop = idMedicion;
                        KPIData.Top300Productos.Add(topProductos);
                    }
                    catch
                    {
                        return BadRequest("El codigo" + " " + nuevo + " " + "no existe, por favor verifiquelo y vuelva a cargar la lista");
                    }
                }


            }


            KPIData.SaveChanges();
            return Ok();
        }




        [HttpPut]
        [Route("api/kpiPlatform/ActualizarMargenes")]
        public IHttpActionResult ActualizarMargenes(List<Margen_Categorias> ActualizarMargen)
        {
            foreach (Margen_Categorias nuevo in ActualizarMargen)
            {
                var Categoria = KPIData.Margen_Categorias.FirstOrDefault(c => c.Codigo_Categoria == nuevo.Codigo_Categoria);
                Categoria.Maximo_Importado = nuevo.Maximo_Importado;
                Categoria.Minimo_Importado = nuevo.Minimo_Importado;
                Categoria.Maximo_Nacional = nuevo.Maximo_Nacional;
                Categoria.Minimo_Nacional = nuevo.Minimo_Nacional;
                KPIData.SaveChanges();
            }

            return Ok();
        }




    }


  




}
