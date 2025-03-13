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
        //Es el servicio que se va a exponer: GET, POST, PUT, DELETE   
        //GET: Se utiliza para consultar informacion, no se debe modificar la base de datos
        //POST: Se utiliza para insertar informacion en la base de datos
        //PUT: Se utiliza para modificar (Actualizar) informacion en la base de datos
        //DELETE: Se utiliza para eliminar informacion en la base de datos

        [HttpGet]
        [Route("consultarTodos")]
        public List<Vivienda> consultarTodos()
        {
            clsViviendas objvivi = new clsViviendas();
            //Se invoca el metodo ConsultarTodos() de la clase clsVivienda
            return objvivi.ConsultarTodos();
        }

        [HttpGet]
        [Route("consultarVivienda")]//Es el nombre de la funcionalidad que se va a ejecutar.         
        public Vivienda consultarVivienda(int codigo)
        {
            //Se crea una instancia de la clase clsViviendas
            clsViviendas objvivi = new clsViviendas();
            return objvivi.Consultar(codigo);
        }

        [HttpPost]
        [Route("insertarVivienda")]
        public string insertarVivienda([FromBody] Vivienda vivienda)
        {
            //Se crea una instancia de la clase clsVivienda
            clsViviendas objvivi = new clsViviendas();
            //Se pasa la propiedad empleado al objeto de la clase clsVivienda
            objvivi.Vivienda = vivienda;
            //Se invoca el metodo insertar
            return objvivi.Insertar();
        }

        [HttpPut]
        [Route("actualizarVivienda")]
        public string actualizarVivienda([FromBody] Vivienda vivienda)
        {
            //Se crea una instancia de la clase clsVivienda
            clsViviendas objvivi = new clsViviendas();
            objvivi.Vivienda = vivienda;
            // se llama al metodo actualizar 
            return objvivi.Actualizar();
        }

        [HttpDelete]
        [Route("eliminarVivienda")]
        public string eliminarVivienda([FromBody] Vivienda vivienda)
        {
            //Se crea una instancia de la clase clsvivienda
            clsViviendas objvivi = new clsViviendas();
            objvivi.Vivienda = vivienda;
            // se llama al metodo eliminar
            return objvivi.Eliminar();
        }
    }
}