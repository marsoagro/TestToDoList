using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prueba_Imfarsa.Clases;
using Prueba_Imfarsa.Modelo;

namespace Prueba_Imfarsa
{
	public partial class AgregarTarea : Form
	{
		LogicaNegocio logica_ = new LogicaNegocio();
		Form1 forminicial = new Form1();
		List<Prioridad> prioridades = new List<Prioridad>();
		Prueba_ImfarsaEntities db = new Prueba_ImfarsaEntities();
		public AgregarTarea(Form1 form1 )
		{
			InitializeComponent();
			forminicial = form1;
		}

		private void cmdSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cmdGuardar_Click(object sender, EventArgs e)
		{
			int id = 0;
			bool flag = true;
			if(string.IsNullOrEmpty(txtDescripcion.Text))
			{
				flag = false;
				MessageBox.Show("La descripción, no debe estar vacia", "ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if(datFin.Value < datInicio.Value)
			{
				flag = false;
				MessageBox.Show("La fecha fin no puede ser menor a la fecha de inicio de la tarea", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if(cmbPrioridad.SelectedIndex ==-1)
			{
				flag = false;
				MessageBox.Show("Seleccione una prioridad a la tarea", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else if (string.IsNullOrEmpty(cmbPrioridad.SelectedValue.ToString()))
			{
				flag = false;
				MessageBox.Show("Seleccione una prioridad valida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (flag)
			{
				int idprioridad = Convert.ToInt32(cmbPrioridad.SelectedValue);
				id = logica_.CrearTarea(txtDescripcion.Text, datInicio.Value, datFin.Value, idprioridad);

				if(id >0)
				{

					MessageBox.Show("Se creo la tarea No. "+ id.ToString(), "To Do List", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
					
				}
				else
				{
					MessageBox.Show("Ocurrio un error al guardar la tarea", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void AgregarTarea_FormClosing(object sender, FormClosingEventArgs e)
		{
			forminicial.GridTareas.DataSource = logica_.GetTareas();
			forminicial.IconPrioridad();
		}

		private void AgregarTarea_Load(object sender, EventArgs e)
		{
			datInicio.Value = DateTime.Now;
			datFin.Value = DateTime.Now;
			prioridades = (from p in db.Prioridad select p).ToList();

			cmbPrioridad.DataSource = prioridades;
			cmbPrioridad.ValueMember = "Id_Prioridad";
			cmbPrioridad.DisplayMember = "Nombre";
		}
	}
}
