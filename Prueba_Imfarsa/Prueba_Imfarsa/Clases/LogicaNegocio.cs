using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prueba_Imfarsa.Modelo;

namespace Prueba_Imfarsa.Clases
{
	class LogicaNegocio
	{
		Prueba_ImfarsaEntities db = new Prueba_ImfarsaEntities();

		//Obtenemos el listado de tareas ya creadas
		public  DataTable GetTareas()
		{
			DataTable tabla = new DataTable();
			DataColumn Id_Tarea = tabla.Columns.Add("Id_Tarea", typeof(int));
			DataColumn Descripcion = tabla.Columns.Add("Descripcion", typeof(string));
			DataColumn Id_Estado = tabla.Columns.Add("Id_Estado", typeof(int));
			DataColumn Estado_Tarea = tabla.Columns.Add("Estado_Tarea", typeof(string));
			DataColumn Fecha_Fin = tabla.Columns.Add("Fecha_Fin", typeof(DateTime));
			DataColumn Prioridad = tabla.Columns.Add("Prioridad", typeof(string));
			DataColumn Id_Prioridad = tabla.Columns.Add("Id_Prioridad", typeof(int));

			var list = (from p in db.Tarea select  new
			{ 
				Id_Tarea=p.Id_Tarea,
				Descripcion=p.Descripcion,
				Id_Estado=p.Id_Estado,
				Estado_Tarea= p.Estado_Tarea.Nombre,
				Fecha_Fin=p.Fecha_Fin,
				Id_Prioridad=p.Id_Prioridad,
				Prioridad=p.Prioridad.Nombre
			}).ToList();

			foreach(var i in list)
			{
				DataRow linea = tabla.NewRow();
				linea["Id_Tarea"] = i.Id_Tarea;
				linea["Descripcion"] = i.Descripcion;
				linea["Id_Estado"] = i.Id_Estado;
				linea["Estado_Tarea"] = i.Estado_Tarea;
				linea["Fecha_Fin"] = i.Fecha_Fin;
				linea["Prioridad"] = i.Prioridad;
				linea["Id_Prioridad"] = i.Id_Prioridad;

				tabla.Rows.Add(linea);
			}
						
			return tabla;
		}

		//Metodo utilizado para insertar tareas
		public int CrearTarea (string descripcion, DateTime inicio, DateTime fin, int priori)
		{
			int idtarea = 0;
			Tarea task = new Tarea
			{
				Descripcion = descripcion,
				Fecha_Creacion = DateTime.Now,
				Id_Estado = 1,
				Fecha_Inicio=inicio,
				Fecha_Fin=fin,
				Id_Prioridad=priori

			};

			db.Tarea.Add(task);
			db.SaveChanges();

			idtarea = task.Id_Tarea;

			return idtarea;

		}

		//Metodo utiliado para completar las tareas
		public bool CambiarEstado (int idTarea, int Estado)
		{
			bool flag=true;

			Tarea task = db.Tarea.Find(idTarea);

			if(task != null)
			{
				db.Entry(task).State = EntityState.Modified;
				task.Fecha_Estado = DateTime.Now;
				task.Id_Estado = Estado;
				db.SaveChanges();
				flag = true;
			}
			else
			{
				flag = false;
			}

			return flag;
		}

		//Metodo Utilizado Para Eliminar Las tareas
		public bool EliminarTarea(int idTarea)
		{
			bool flag = true;

			Tarea task = db.Tarea.Find(idTarea);

			if (task != null)
			{
				db.Tarea.Remove(task);
				db.SaveChanges();
				flag = true;
			}
			else
			{
				flag = false;
			}

			return flag;
		}
	}
}
