/*
 * Creado por SharpDevelop.
 * Usuario: a4dew
 * Fecha: 12/12/2025
 * Hora: 01:51 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace GermanxChino
{
	partial class Boleta
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Boleta));
			this.label11 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtPromedio = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtFecha = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtp2 = new System.Windows.Forms.TextBox();
			this.txtp3 = new System.Windows.Forms.TextBox();
			this.txtp1 = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cboAsignatura = new System.Windows.Forms.ComboBox();
			this.cboSemestre = new System.Windows.Forms.ComboBox();
			this.cboEspecialidad = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(190, 13);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(590, 29);
			this.label11.TabIndex = 24;
			this.label11.Text = "Centro de bachillerato tecnologico, industrial y de servicios N.217";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 13);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(138, 134);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 23;
			this.pictureBox1.TabStop = false;
			// 
			// txtPromedio
			// 
			this.txtPromedio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPromedio.Enabled = false;
			this.txtPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPromedio.Location = new System.Drawing.Point(212, 668);
			this.txtPromedio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtPromedio.Name = "txtPromedio";
			this.txtPromedio.Size = new System.Drawing.Size(162, 32);
			this.txtPromedio.TabIndex = 22;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(-4, 664);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(210, 46);
			this.label10.TabIndex = 21;
			this.label10.Text = "Promedio general:";
			// 
			// btnSalir
			// 
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Location = new System.Drawing.Point(801, 349);
			this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(119, 41);
			this.btnSalir.TabIndex = 20;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrar.Location = new System.Drawing.Point(529, 349);
			this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(116, 41);
			this.btnRegistrar.TabIndex = 19;
			this.btnRegistrar.Text = "Registrar";
			this.btnRegistrar.UseVisualStyleBackColor = true;
			this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrarClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Location = new System.Drawing.Point(668, 349);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(112, 41);
			this.btnCancelar.TabIndex = 18;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// listView1
			// 
			this.listView1.BackColor = System.Drawing.Color.MistyRose;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader4,
									this.columnHeader5,
									this.columnHeader6});
			this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listView1.Location = new System.Drawing.Point(120, 398);
			this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(771, 262);
			this.listView1.TabIndex = 17;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Asignatura";
			this.columnHeader1.Width = 89;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Parcial 1";
			this.columnHeader2.Width = 81;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Parcial 2";
			this.columnHeader3.Width = 80;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Parcial 3";
			this.columnHeader4.Width = 83;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Promedio";
			this.columnHeader5.Width = 87;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Aprobado/Reprobado";
			this.columnHeader6.Width = 169;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
			this.groupBox1.Controls.Add(this.txtFecha);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.txtp2);
			this.groupBox1.Controls.Add(this.txtp3);
			this.groupBox1.Controls.Add(this.txtp1);
			this.groupBox1.Controls.Add(this.txtNombre);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.cboAsignatura);
			this.groupBox1.Controls.Add(this.cboSemestre);
			this.groupBox1.Controls.Add(this.cboEspecialidad);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(190, 75);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox1.Size = new System.Drawing.Size(764, 266);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			// 
			// txtFecha
			// 
			this.txtFecha.Enabled = false;
			this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFecha.Location = new System.Drawing.Point(514, 188);
			this.txtFecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtFecha.Name = "txtFecha";
			this.txtFecha.Size = new System.Drawing.Size(187, 32);
			this.txtFecha.TabIndex = 15;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(365, 191);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(143, 29);
			this.label9.TabIndex = 6;
			this.label9.Text = "Fecha actual:";
			// 
			// txtp2
			// 
			this.txtp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtp2.Location = new System.Drawing.Point(545, 51);
			this.txtp2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtp2.Name = "txtp2";
			this.txtp2.Size = new System.Drawing.Size(79, 32);
			this.txtp2.TabIndex = 14;
			// 
			// txtp3
			// 
			this.txtp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtp3.Location = new System.Drawing.Point(662, 55);
			this.txtp3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtp3.Name = "txtp3";
			this.txtp3.Size = new System.Drawing.Size(79, 32);
			this.txtp3.TabIndex = 13;
			// 
			// txtp1
			// 
			this.txtp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtp1.Location = new System.Drawing.Point(429, 51);
			this.txtp1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtp1.Name = "txtp1";
			this.txtp1.Size = new System.Drawing.Size(79, 32);
			this.txtp1.TabIndex = 12;
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(22, 55);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(353, 32);
			this.txtNombre.TabIndex = 11;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(22, 169);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(280, 40);
			this.label8.TabIndex = 10;
			this.label8.Text = "Asignatura o submodulo:";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(362, 118);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(146, 29);
			this.label7.TabIndex = 9;
			this.label7.Text = "Especialidad:";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(22, 118);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(112, 29);
			this.label6.TabIndex = 8;
			this.label6.Text = "Semestre:";
			// 
			// cboAsignatura
			// 
			this.cboAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboAsignatura.FormattingEnabled = true;
			this.cboAsignatura.Items.AddRange(new object[] {
									"Matematicas",
									"Ecosistemas",
									"Lengua y Comunicacion",
									"Metodologias Agiles",
									"Emplea Frameworks",
									"Ingles",
									"Humanidades",
									"Socioemocional"});
			this.cboAsignatura.Location = new System.Drawing.Point(22, 213);
			this.cboAsignatura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cboAsignatura.Name = "cboAsignatura";
			this.cboAsignatura.Size = new System.Drawing.Size(255, 34);
			this.cboAsignatura.TabIndex = 7;
			// 
			// cboSemestre
			// 
			this.cboSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboSemestre.FormattingEnabled = true;
			this.cboSemestre.Items.AddRange(new object[] {
									"1ro",
									"2do",
									"3ro",
									"4to",
									"5to",
									"6to"});
			this.cboSemestre.Location = new System.Drawing.Point(140, 118);
			this.cboSemestre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cboSemestre.Name = "cboSemestre";
			this.cboSemestre.Size = new System.Drawing.Size(136, 34);
			this.cboSemestre.TabIndex = 6;
			// 
			// cboEspecialidad
			// 
			this.cboEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboEspecialidad.FormattingEnabled = true;
			this.cboEspecialidad.Items.AddRange(new object[] {
									"Programacion",
									"Contabilidad",
									"Soporte",
									"Ciberseguridad",
									"Alimentos",
									"Administracion",
									"Ofimatica"});
			this.cboEspecialidad.Location = new System.Drawing.Point(533, 118);
			this.cboEspecialidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cboEspecialidad.Name = "cboEspecialidad";
			this.cboEspecialidad.Size = new System.Drawing.Size(208, 34);
			this.cboEspecialidad.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(22, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(215, 29);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nombre del alumno:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(646, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 29);
			this.label4.TabIndex = 3;
			this.label4.Text = "Parcial 3:";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(528, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(112, 29);
			this.label5.TabIndex = 4;
			this.label5.Text = "Parcial 2:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(410, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 29);
			this.label3.TabIndex = 2;
			this.label3.Text = "Parcial 1:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(208, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(541, 41);
			this.label1.TabIndex = 15;
			this.label1.Text = "BOLETA DE CALIFICACIONES ";
			// 
			// Boleta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.RosyBrown;
			this.ClientSize = new System.Drawing.Size(1029, 742);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txtPromedio);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Name = "Boleta";
			this.Text = "Boleta";
			this.Load += new System.EventHandler(this.BoletaLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cboEspecialidad;
		private System.Windows.Forms.ComboBox cboSemestre;
		private System.Windows.Forms.ComboBox cboAsignatura;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtp1;
		private System.Windows.Forms.TextBox txtp3;
		private System.Windows.Forms.TextBox txtp2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtFecha;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtPromedio;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label11;
	}
}
