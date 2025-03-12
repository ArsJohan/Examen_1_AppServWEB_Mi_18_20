using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VentasViviendas.Models;
using VentasViviendas.Clases;

namespace VentasViviendas.Controllers
{
    [RoutePrefix("api/Viviendas")]
    public class ViviendasController : ApiController
    {
        [HttpGet]
        [Route("consultarTodos")]
        public List<Vivienda> consultarTodos()
        {
            clsViviendas objvivi = new clsViviendas();
            return objvivi.ConsultarTodos();
        }

        [HttpGet]
        [Route("consultarVivienda")]
        public Vivienda consultarVivienda(int codigo)
        {
            clsViviendas objvivi = new clsViviendas();
            return objvivi.Consultar(codigo);
        }

        [HttpPost]
        [Route("insertarVivienda")]
        public string insertarVivienda([FromBody] Vivienda vivienda)
        {
            clsViviendas objvivi = new clsViviendas();
            objvivi.Vivienda = vivienda;
            return objvivi.Insertar();
        }

        [HttpPut]
        [Route("actualizarVivienda")]
        public string actualizarVivienda([FromBody] Vivienda vivienda)
        { 
            clsViviendas objvivi = new clsViviendas();
            objvivi.Vivienda = vivienda;
            return objvivi.Actualizar();
        }

        [HttpDelete]
        [Route("eliminarVivienda")]
        public string eliminarVivienda([FromBody] Vivienda vivienda)
        {
            clsViviendas objvivi = new clsViviendas();
            objvivi.Vivienda = vivienda;
            return objvivi.Eliminar();
        }
    }
}