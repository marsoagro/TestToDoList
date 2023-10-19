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

namespace Prueba_Imfarsa
{
	public partial class Form1 : Form
	{
		LogicaNegocio logica_ = new LogicaNegocio();
		public Form1()
		{
			InitializeComponent();
		}

		//Menu de agregar Tarea
		private void crearTareaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AgregarTarea formagregar = new AgregarTarea(this);
			formagregar.ShowDialog();
		}

		//Menu de Completar Tarea
		private void marcarCompletadaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag;
			if (GridTareas.RowCount > 0)
			{
				//El id para una tarea completada es 3

				String idtarea = GridTareas.CurrentRow.Cells["idTareaDataGridViewTextBoxColumn"].Value.ToString();
				String idestado = GridTareas.CurrentRow.Cells["idEstadoDataGridViewTextBoxColumn"].Value.ToString();
				if (string.IsNullOrEmpty(idtarea))
				{
					flag = false;
					MessageBox.Show("Seleccione una fila valida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (string.IsNullOrEmpty(idestado))
				{
					flag = false;
					MessageBox.Show("Seleccione una fila valida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				else
				{
					if(idestado=="3")
					{
						flag = false;
						MessageBox.Show("La tarea ya fue completada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					else
					{

						flag = logica_.CambiarEstado(Convert.ToInt32(idtarea), 3);

						if (flag)
						{
							MessageBox.Show("Se completo la tarea No. " + idtarea, "To Do List", MessageBoxButtons.OK, MessageBoxIcon.Information);
							GridTareas.DataSource = logica_.GetTareas(); IconPrioridad();
						}
					}
				}

				


			}
			else
			{
				flag = false;
				MessageBox.Show("No hay datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//Menu de Eliminar Tarea
		private void eliminarTareaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag;
			if (GridTareas.RowCount > 0)
			{
				//El id para una tarea completada es 3

				String idtarea = GridTareas.CurrentRow.Cells["idTareaDataGridViewTextBoxColumn"].Value.ToString();

				if (string.IsNullOrEmpty(idtarea))
				{
					flag = false;
					MessageBox.Show("Seleccione una fila valida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				else
				{
					//Vamos a confirmar la elominación de la tarea
					if (MessageBox.Show("Desea eliminar la tarea No.  " + idtarea, "To Do List",
	MessageBoxButtons.YesNo, MessageBoxIcon.Question,
	MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)

					{
						flag = logica_.EliminarTarea(Convert.ToInt32(idtarea));

						if (flag)
						{
							MessageBox.Show("Se elimino la tarea No. " + idtarea, "To Do List", MessageBoxButtons.OK, MessageBoxIcon.Information);
							GridTareas.DataSource = logica_.GetTareas();
							IconPrioridad();
						}
					}


				}


			}
			else
			{
				flag = false;
				MessageBox.Show("No hay datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}



		}

		private void Form1_Load(object sender, EventArgs e)
		{
			GridTareas.DataSource = logica_.GetTareas();
			//DT.Columns.Add("c", System.Windows.Forms.DataGridViewImageCell);
			IconPrioridad();			


		}

		public void IconPrioridad()
		{
			foreach (DataGridViewRow row in GridTareas.Rows)
			{
				if (row.Cells["idPrioridadDataGridViewTextBoxColumn"].Value.ToString() == "1")
					row.Cells["Priority"].Value = (System.Drawing.Image)Properties.Resources.script_yellow;
				else if (row.Cells["idPrioridadDataGridViewTextBoxColumn"].Value.ToString() == "2")
					row.Cells["Priority"].Value = (System.Drawing.Image)Properties.Resources.script_green;
				else
					row.Cells["Priority"].Value = (System.Drawing.Image)Properties.Resources.script_red;

			}
		}

		private void GridTareas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (this.GridTareas.Columns[e.ColumnIndex].Name == "estadoTareaDataGridViewTextBoxColumn")
				if (e.Value != null)
				{
					if (e.Value.GetType() != typeof(System.DBNull))
					{
						if (e.Value.ToString() == "Completada")
						e.CellStyle.BackColor = System.Drawing.Color.LightGreen;
					}

				}
					
		}
	}
}
