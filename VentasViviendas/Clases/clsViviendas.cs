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
		private DBVentasViviendaEntities dbVivienda = new DBVentasViviendaEntities();
		public Vivienda Vivienda { get; set; }

		public string Insertar()
		{
			try
			{
				dbVivienda.Viviendas.Add(Vivienda);
				dbVivienda.SaveChanges();
				return "Vivienda insertada correctamente";
			}
			catch (Exception ex)
			{
				return "Vivienda no se inserto correctamente";
			}
		}
		public Vivienda Consultar(int codigo) 
		{
			return dbVivienda.Viviendas.FirstOrDefault(v => v.codigo == codigo);
		}
		public List<Vivienda> ConsultarTodos()
		{ 
			return dbVivienda.Viviendas
				.OrderBy(v => v.codigo) //Ordenamos por el codigo de la vivienda.
				.ToList();
		}
		public string Actualizar() 
		{
			try
			{
				Vivienda vivi = Consultar(Vivienda.codigo);
				if (vivi == null) 
				{
					return "la vivienda con el codigo ingresado nmo existe, por ende no se puede actualizar ";
				}
				//Si la vivienda existe lo podemos actualizar
				dbVivienda.Viviendas.AddOrUpdate(Vivienda);
				dbVivienda.SaveChanges ();
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
                Vivienda vivi = Consultar(Vivienda.codigo);
                if (vivi == null)
                {
                    return "la vivienda con el codigo ingresado nmo existe, por ende no se puede Eliminar ";
                }
                //Si la vivienda existe lo podemos actualizar
                dbVivienda.Viviendas.Remove(vivi);
                dbVivienda.SaveChanges();
                return "Se elimino la vivienda correctamente";
            }
            catch (Exception ex)
            {

                return "No se pudo actualizar la vivienda: " + ex.Message;
            }
        }
	}
}