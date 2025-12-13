/*
 * Creado por SharpDevelop.
 * Usuario: tijam
 * Fecha: 06/12/2025
 * Hora: 09:07 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace GermanxChino
{
	partial class Empleados
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtCodigoEmpleado = new System.Windows.Forms.TextBox();
			this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
			this.cboPuesto = new System.Windows.Forms.ComboBox();
			this.cboSex = new System.Windows.Forms.ComboBox();
			this.rdbRegular = new System.Windows.Forms.RadioButton();
			this.rdbContrato = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.btnQuitar = new System.Windows.Forms.Button();
			this.dataLista = new System.Windows.Forms.DataGridView();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.erpHerror = new System.Windows.Forms.ErrorProvider(this.components);
			this.datiFechaNac = new System.Windows.Forms.DateTimePicker();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpHerror)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Codigo de empleado:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(149, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nombre del empleado:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Puesto:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(13, 94);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(142, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Fecha de nacimiento:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(13, 121);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Sexo:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(13, 158);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "Estado:";
			// 
			// txtCodigoEmpleado
			// 
			this.txtCodigoEmpleado.Location = new System.Drawing.Point(169, 10);
			this.txtCodigoEmpleado.Name = "txtCodigoEmpleado";
			this.txtCodigoEmpleado.Size = new System.Drawing.Size(126, 26);
			this.txtCodigoEmpleado.TabIndex = 6;
			this.txtCodigoEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtNombreEmpleado
			// 
			this.txtNombreEmpleado.Location = new System.Drawing.Point(169, 37);
			this.txtNombreEmpleado.Name = "txtNombreEmpleado";
			this.txtNombreEmpleado.Size = new System.Drawing.Size(126, 26);
			this.txtNombreEmpleado.TabIndex = 7;
			this.txtNombreEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cboPuesto
			// 
			this.cboPuesto.FormattingEnabled = true;
			this.cboPuesto.Items.AddRange(new object[] {
									"Operativo",
									"Administrador",
									"Surpevisor",
									"Gerente",
									"Conserge"});
			this.cboPuesto.Location = new System.Drawing.Point(169, 65);
			this.cboPuesto.Name = "cboPuesto";
			this.cboPuesto.Size = new System.Drawing.Size(126, 28);
			this.cboPuesto.TabIndex = 8;
			// 
			// cboSex
			// 
			this.cboSex.FormattingEnabled = true;
			this.cboSex.Items.AddRange(new object[] {
									"Masculino",
									"Femenino"});
			this.cboSex.Location = new System.Drawing.Point(169, 121);
			this.cboSex.Name = "cboSex";
			this.cboSex.Size = new System.Drawing.Size(126, 28);
			this.cboSex.TabIndex = 10;
			// 
			// rdbRegular
			// 
			this.rdbRegular.Location = new System.Drawing.Point(27, 10);
			this.rdbRegular.Name = "rdbRegular";
			this.rdbRegular.Size = new System.Drawing.Size(93, 24);
			this.rdbRegular.TabIndex = 11;
			this.rdbRegular.TabStop = true;
			this.rdbRegular.Text = "Regular";
			this.rdbRegular.UseVisualStyleBackColor = true;
			// 
			// rdbContrato
			// 
			this.rdbContrato.Location = new System.Drawing.Point(123, 11);
			this.rdbContrato.Name = "rdbContrato";
			this.rdbContrato.Size = new System.Drawing.Size(107, 24);
			this.rdbContrato.TabIndex = 12;
			this.rdbContrato.TabStop = true;
			this.rdbContrato.Text = "Contrato";
			this.rdbContrato.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdbRegular);
			this.groupBox1.Controls.Add(this.rdbContrato);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Location = new System.Drawing.Point(119, 148);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(235, 40);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(502, 13);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(131, 131);
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			// 
			// btnActualizar
			// 
			this.btnActualizar.BackColor = System.Drawing.Color.MistyRose;
			this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnActualizar.Location = new System.Drawing.Point(477, 158);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(106, 30);
			this.btnActualizar.TabIndex = 15;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = false;
			this.btnActualizar.Click += new System.EventHandler(this.BtnActualizarClick);
			// 
			// btnQuitar
			// 
			this.btnQuitar.BackColor = System.Drawing.Color.MistyRose;
			this.btnQuitar.Enabled = false;
			this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnQuitar.Location = new System.Drawing.Point(589, 157);
			this.btnQuitar.Name = "btnQuitar";
			this.btnQuitar.Size = new System.Drawing.Size(75, 31);
			this.btnQuitar.TabIndex = 16;
			this.btnQuitar.Text = "Quitar";
			this.btnQuitar.UseVisualStyleBackColor = false;
			this.btnQuitar.Click += new System.EventHandler(this.BtnQuitarClick);
			// 
			// dataLista
			// 
			this.dataLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataLista.Location = new System.Drawing.Point(13, 205);
			this.dataLista.Name = "dataLista";
			this.dataLista.Size = new System.Drawing.Size(707, 150);
			this.dataLista.TabIndex = 17;
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.Color.MistyRose;
			this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGuardar.Location = new System.Drawing.Point(12, 361);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(83, 38);
			this.btnGuardar.TabIndex = 18;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = false;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.MistyRose;
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminar.Location = new System.Drawing.Point(143, 361);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(83, 38);
			this.btnEliminar.TabIndex = 19;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.BackColor = System.Drawing.Color.MistyRose;
			this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimpiar.Location = new System.Drawing.Point(637, 361);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(83, 38);
			this.btnLimpiar.TabIndex = 20;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = false;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// erpHerror
			// 
			this.erpHerror.ContainerControl = this;
			// 
			// datiFechaNac
			// 
			this.datiFechaNac.Location = new System.Drawing.Point(169, 94);
			this.datiFechaNac.Name = "datiFechaNac";
			this.datiFechaNac.Size = new System.Drawing.Size(293, 26);
			this.datiFechaNac.TabIndex = 21;
			this.datiFechaNac.Value = new System.DateTime(2025, 12, 12, 0, 0, 0, 0);
			// 
			// Empleados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.RosyBrown;
			this.ClientSize = new System.Drawing.Size(732, 409);
			this.Controls.Add(this.datiFechaNac);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.dataLista);
			this.Controls.Add(this.btnQuitar);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.cboSex);
			this.Controls.Add(this.cboPuesto);
			this.Controls.Add(this.txtNombreEmpleado);
			this.Controls.Add(this.txtCodigoEmpleado);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Empleados";
			this.Text = "Detalles de empleado";
			this.Load += new System.EventHandler(this.EmpleadosLoad);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataLista)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpHerror)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DateTimePicker datiFechaNac;
		private System.Windows.Forms.ErrorProvider erpHerror;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.DataGridView dataLista;
		private System.Windows.Forms.Button btnQuitar;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdbContrato;
		private System.Windows.Forms.RadioButton rdbRegular;
		private System.Windows.Forms.ComboBox cboSex;
		private System.Windows.Forms.ComboBox cboPuesto;
		private System.Windows.Forms.TextBox txtNombreEmpleado;
		private System.Windows.Forms.TextBox txtCodigoEmpleado;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
