
namespace Prueba_Imfarsa
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.GridTareas = new System.Windows.Forms.DataGridView();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.crearTareaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.marcarCompletadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.eliminarTareaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Priority = new System.Windows.Forms.DataGridViewImageColumn();
			this.idTareaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.prioridadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.estadoTareaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fechaFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idEstadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idPrioridadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tareaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.GridTareas)).BeginInit();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// GridTareas
			// 
			this.GridTareas.AllowUserToAddRows = false;
			this.GridTareas.AllowUserToDeleteRows = false;
			this.GridTareas.AutoGenerateColumns = false;
			this.GridTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Priority,
            this.idTareaDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.prioridadDataGridViewTextBoxColumn,
            this.estadoTareaDataGridViewTextBoxColumn,
            this.fechaFinDataGridViewTextBoxColumn,
            this.idEstadoDataGridViewTextBoxColumn,
            this.idPrioridadDataGridViewTextBoxColumn});
			this.GridTareas.DataSource = this.tareaBindingSource;
			this.GridTareas.Location = new System.Drawing.Point(12, 40);
			this.GridTareas.MultiSelect = false;
			this.GridTareas.Name = "GridTareas";
			this.GridTareas.ReadOnly = true;
			this.GridTareas.Size = new System.Drawing.Size(776, 297);
			this.GridTareas.TabIndex = 0;
			this.GridTareas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GridTareas_CellFormatting);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearTareaToolStripMenuItem,
            this.marcarCompletadaToolStripMenuItem,
            this.eliminarTareaToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// crearTareaToolStripMenuItem
			// 
			this.crearTareaToolStripMenuItem.Image = global::Prueba_Imfarsa.Properties.Resources.wishlist_add;
			this.crearTareaToolStripMenuItem.Name = "crearTareaToolStripMenuItem";
			this.crearTareaToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
			this.crearTareaToolStripMenuItem.Text = "Crear tarea";
			this.crearTareaToolStripMenuItem.Click += new System.EventHandler(this.crearTareaToolStripMenuItem_Click);
			// 
			// marcarCompletadaToolStripMenuItem
			// 
			this.marcarCompletadaToolStripMenuItem.Image = global::Prueba_Imfarsa.Properties.Resources.check_box;
			this.marcarCompletadaToolStripMenuItem.Name = "marcarCompletadaToolStripMenuItem";
			this.marcarCompletadaToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
			this.marcarCompletadaToolStripMenuItem.Text = "Marcar completada";
			this.marcarCompletadaToolStripMenuItem.Click += new System.EventHandler(this.marcarCompletadaToolStripMenuItem_Click);
			// 
			// eliminarTareaToolStripMenuItem
			// 
			this.eliminarTareaToolStripMenuItem.Image = global::Prueba_Imfarsa.Properties.Resources.bullet_delete;
			this.eliminarTareaToolStripMenuItem.Name = "eliminarTareaToolStripMenuItem";
			this.eliminarTareaToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
			this.eliminarTareaToolStripMenuItem.Text = "Eliminar tarea";
			this.eliminarTareaToolStripMenuItem.Click += new System.EventHandler(this.eliminarTareaToolStripMenuItem_Click);
			// 
			// Priority
			// 
			this.Priority.HeaderText = "";
			this.Priority.Name = "Priority";
			this.Priority.ReadOnly = true;
			// 
			// idTareaDataGridViewTextBoxColumn
			// 
			this.idTareaDataGridViewTextBoxColumn.DataPropertyName = "Id_Tarea";
			this.idTareaDataGridViewTextBoxColumn.HeaderText = "Id Tarea";
			this.idTareaDataGridViewTextBoxColumn.Name = "idTareaDataGridViewTextBoxColumn";
			this.idTareaDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// descripcionDataGridViewTextBoxColumn
			// 
			this.descripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
			this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
			this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
			this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// prioridadDataGridViewTextBoxColumn
			// 
			this.prioridadDataGridViewTextBoxColumn.DataPropertyName = "Prioridad";
			this.prioridadDataGridViewTextBoxColumn.HeaderText = "Prioridad";
			this.prioridadDataGridViewTextBoxColumn.Name = "prioridadDataGridViewTextBoxColumn";
			this.prioridadDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// estadoTareaDataGridViewTextBoxColumn
			// 
			this.estadoTareaDataGridViewTextBoxColumn.DataPropertyName = "Estado_Tarea";
			this.estadoTareaDataGridViewTextBoxColumn.HeaderText = "Estado";
			this.estadoTareaDataGridViewTextBoxColumn.Name = "estadoTareaDataGridViewTextBoxColumn";
			this.estadoTareaDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// fechaFinDataGridViewTextBoxColumn
			// 
			this.fechaFinDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Fin";
			dataGridViewCellStyle1.Format = "d";
			dataGridViewCellStyle1.NullValue = null;
			this.fechaFinDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
			this.fechaFinDataGridViewTextBoxColumn.HeaderText = "Fecha Fin";
			this.fechaFinDataGridViewTextBoxColumn.Name = "fechaFinDataGridViewTextBoxColumn";
			this.fechaFinDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// idEstadoDataGridViewTextBoxColumn
			// 
			this.idEstadoDataGridViewTextBoxColumn.DataPropertyName = "Id_Estado";
			this.idEstadoDataGridViewTextBoxColumn.HeaderText = "Id_Estado";
			this.idEstadoDataGridViewTextBoxColumn.Name = "idEstadoDataGridViewTextBoxColumn";
			this.idEstadoDataGridViewTextBoxColumn.ReadOnly = true;
			this.idEstadoDataGridViewTextBoxColumn.Visible = false;
			// 
			// idPrioridadDataGridViewTextBoxColumn
			// 
			this.idPrioridadDataGridViewTextBoxColumn.DataPropertyName = "Id_Prioridad";
			this.idPrioridadDataGridViewTextBoxColumn.HeaderText = "Id_Prioridad";
			this.idPrioridadDataGridViewTextBoxColumn.Name = "idPrioridadDataGridViewTextBoxColumn";
			this.idPrioridadDataGridViewTextBoxColumn.ReadOnly = true;
			this.idPrioridadDataGridViewTextBoxColumn.Visible = false;
			// 
			// tareaBindingSource
			// 
			this.tareaBindingSource.DataSource = typeof(Prueba_Imfarsa.Modelo.Tarea);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 354);
			this.Controls.Add(this.GridTareas);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Listado de Tareas";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.GridTareas)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem crearTareaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem eliminarTareaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem marcarCompletadaToolStripMenuItem;
		public System.Windows.Forms.DataGridView GridTareas;
		private System.Windows.Forms.BindingSource tareaBindingSource;
		private System.Windows.Forms.DataGridViewImageColumn Priority;
		private System.Windows.Forms.DataGridViewTextBoxColumn idTareaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn prioridadDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn estadoTareaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idEstadoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idPrioridadDataGridViewTextBoxColumn;
	}
}

