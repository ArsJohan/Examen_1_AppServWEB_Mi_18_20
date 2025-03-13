using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using VentasViviendas.Models;

namespace VentasViviendas.Clases
{
	public class clsViviendas
	{
		//Contexto para la gestion de la conexion con la base de datos.
		private DBVentasViviendaEntities dbVivienda = new DBVentasViviendaEntities(); //Es el atributo (Propiedad) para gestionar la conexion a la base de datos
        public Vivienda Vivienda { get; set; } //Propiedad para manipular la informacion en la base de datos: Permite agregar, modificar o eliminar

        public string Insertar()
		{

			try
			{
				dbVivienda.Viviendas.Add(Vivienda); //Agrega el objeto Vivienda a la lista de "Viviendas". Todavia no se agrega a la base de datos. Se debe invocar el metodo SaveChange()
                dbVivienda.SaveChanges(); //Guardar los cambios en la base de datos
                return "Vivienda insertada correctamente";
			}
			catch (Exception ex)
			{
				return "Vivienda no se inserto correctamente";
			}
		}
		public Vivienda Consultar(int codigo) 
		{
            //Expresiones lambda. => permite definir funciones anonimas o instancias de objetos, sin la creacion formal, dependiendo de la lista a la cual se hace referencia
            //FirstOrDefault. Es una funcion que permite consultar el primer elemento de una lista que cumple las condiciones solicitadas
            return dbVivienda.Viviendas.FirstOrDefault(v => v.codigo == codigo);
		}
		public List<Vivienda> ConsultarTodos()
		{ 

			return dbVivienda.Viviendas
				.OrderBy(v => v.codigo) //Ordenamos por el codigo de la vivienda.
				.ToList();//ToList() es una funcion que convierte una lista de datos en una lista de objetos
        }
		public string Actualizar() 
		{
            //Antes de actualizar un elemento (Vivienda), se debe consultar para verificar que exista, y ahi si poderlo actualizar
            try
            {
				Vivienda vivi = Consultar(Vivienda.codigo);
				if (vivi == null) 
				{
					return "la vivienda con el codigo ingresado nmo existe, por ende no se puede actualizar ";
				}
				//Si la vivienda existe lo podemos actualizar
				dbVivienda.Viviendas.AddOrUpdate(Vivienda);//Actualiza el objeto Vivienda en la lista de "Vivienda". Todavia no se actualiza en la base de datos. Se debe invocar el metodo SaveChanges()
                dbVivienda.SaveChanges ();//Guarda los cambios en la base de datos
                return "Se actualizo la vivienda correctamente";
			}
			catch (Exception ex)
			{

				return "No se pudo actualizar la vivienda: " + ex.Message;
			}
		}
		public string Eliminar() 
		{
            try
            {
                //Antes de eliminar se debe verificar si el empleado existe
                Vivienda vivi = Consultar(Vivienda.codigo);
                if (vivi == null)
                {
                    return "la vivienda con el codigo ingresado nmo existe, por ende no se puede Eliminar ";
                }
                //Si la vivienda existe lo podemos Eliminar
                dbVivienda.Viviendas.Remove(vivi);//Elimina el objeto Vivienda en la lista de "Vivienda". Todavia no se elimina en la base de datos. Se debe invocar el metodo SaveChanges()
                dbVivienda.SaveChanges();//Guarda los cambios en la base de datos
                return "Se elimino la vivienda correctamente";
            }
            catch (Exception ex)
            {

                return "No se pudo actualizar la vivienda: " + ex.Message;
            }
        }
	}
}