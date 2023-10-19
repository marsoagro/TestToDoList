
namespace Prueba_Imfarsa
{
	partial class AgregarTarea
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.cmdSalir = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.datInicio = new System.Windows.Forms.DateTimePicker();
			this.datFin = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbPrioridad = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Descripción:";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(84, 20);
			this.txtDescripcion.MaxLength = 200;
			this.txtDescripcion.Multiline = true;
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(351, 35);
			this.txtDescripcion.TabIndex = 1;
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Location = new System.Drawing.Point(279, 120);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(75, 23);
			this.cmdGuardar.TabIndex = 2;
			this.cmdGuardar.Text = "Guardar";
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
			// 
			// cmdSalir
			// 
			this.cmdSalir.Location = new System.Drawing.Point(360, 120);
			this.cmdSalir.Name = "cmdSalir";
			this.cmdSalir.Size = new System.Drawing.Size(75, 23);
			this.cmdSalir.TabIndex = 3;
			this.cmdSalir.Text = "Cancelar";
			this.cmdSalir.UseVisualStyleBackColor = true;
			this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(227, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Fecha Fin:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Fecha Inicio:";
			// 
			// datInicio
			// 
			this.datInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.datInicio.Location = new System.Drawing.Point(84, 71);
			this.datInicio.Name = "datInicio";
			this.datInicio.Size = new System.Drawing.Size(137, 20);
			this.datInicio.TabIndex = 6;
			// 
			// datFin
			// 
			this.datFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.datFin.Location = new System.Drawing.Point(290, 71);
			this.datFin.Name = "datFin";
			this.datFin.Size = new System.Drawing.Size(137, 20);
			this.datFin.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Prioridad:";
			// 
			// cmbPrioridad
			// 
			this.cmbPrioridad.FormattingEnabled = true;
			this.cmbPrioridad.Location = new System.Drawing.Point(70, 108);
			this.cmbPrioridad.Name = "cmbPrioridad";
			this.cmbPrioridad.Size = new System.Drawing.Size(187, 21);
			this.cmbPrioridad.TabIndex = 9;
			// 
			// AgregarTarea
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(455, 155);
			this.Controls.Add(this.cmbPrioridad);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.datFin);
			this.Controls.Add(this.datInicio);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmdSalir);
			this.Controls.Add(this.cmdGuardar);
			this.Controls.Add(this.txtDescripcion);
			this.Controls.Add(this.label1);
			this.Name = "AgregarTarea";
			this.Text = "Nueva Tarea";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgregarTarea_FormClosing);
			this.Load += new System.EventHandler(this.AgregarTarea_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.Button cmdSalir;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker datInicio;
		private System.Windows.Forms.DateTimePicker datFin;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbPrioridad;
	}
}