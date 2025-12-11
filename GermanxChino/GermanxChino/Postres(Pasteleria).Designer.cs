/*
 * Creado por SharpDevelop.
 * Usuario: CC_PC20
 * Fecha: 05/12/2025
 * Hora: 02:58 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace GermanxChino
{
	partial class Postres_Pasteleria_
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Postres_Pasteleria_));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.rdbDul = new System.Windows.Forms.RadioButton();
			this.rdbSal = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbSelec = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCan = new System.Windows.Forms.TextBox();
			this.txtTo = new System.Windows.Forms.TextBox();
			this.lvReg = new System.Windows.Forms.ListView();
			this.Postre = new System.Windows.Forms.ColumnHeader();
			this.Tipo = new System.Windows.Forms.ColumnHeader();
			this.Precio = new System.Windows.Forms.ColumnHeader();
			this.Cantidad = new System.Windows.Forms.ColumnHeader();
			this.Total = new System.Windows.Forms.ColumnHeader();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtNeto = new System.Windows.Forms.TextBox();
			this.txtPa = new System.Windows.Forms.TextBox();
			this.txtCam = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.btnAgre = new System.Windows.Forms.Button();
			this.btnEli = new System.Windows.Forms.Button();
			this.txtDes = new System.Windows.Forms.TextBox();
			this.txtSub = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.cmbSal = new System.Windows.Forms.ComboBox();
			this.cmbDul = new System.Windows.Forms.ComboBox();
			this.txtPre = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, -2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(860, 105);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// rdbDul
			// 
			this.rdbDul.Location = new System.Drawing.Point(32, 166);
			this.rdbDul.Name = "rdbDul";
			this.rdbDul.Size = new System.Drawing.Size(104, 24);
			this.rdbDul.TabIndex = 1;
			this.rdbDul.TabStop = true;
			this.rdbDul.Text = "Dulce";
			this.rdbDul.UseVisualStyleBackColor = true;
			this.rdbDul.CheckedChanged += new System.EventHandler(this.RdbDulCheckedChanged);
			// 
			// rdbSal
			// 
			this.rdbSal.Location = new System.Drawing.Point(155, 166);
			this.rdbSal.Name = "rdbSal";
			this.rdbSal.Size = new System.Drawing.Size(104, 24);
			this.rdbSal.TabIndex = 2;
			this.rdbSal.TabStop = true;
			this.rdbSal.Text = "Salado";
			this.rdbSal.UseVisualStyleBackColor = true;
			this.rdbSal.CheckedChanged += new System.EventHandler(this.RdbSalCheckedChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(339, 162);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(166, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Seleccionar Producto:";
			// 
			// cmbSelec
			// 
			this.cmbSelec.FormattingEnabled = true;
			this.cmbSelec.Items.AddRange(new object[] {
									"Pay de queso",
									"Pastel ",
									"Helado",
									"Crepas dulces",
									"Brownie"});
			this.cmbSelec.Location = new System.Drawing.Point(511, 159);
			this.cmbSelec.Name = "cmbSelec";
			this.cmbSelec.Size = new System.Drawing.Size(121, 28);
			this.cmbSelec.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(36, 257);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Precio";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(163, 257);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Cantidad";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(330, 257);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Total";
			// 
			// txtCan
			// 
			this.txtCan.Location = new System.Drawing.Point(159, 281);
			this.txtCan.Name = "txtCan";
			this.txtCan.Size = new System.Drawing.Size(100, 26);
			this.txtCan.TabIndex = 9;
			this.txtCan.TextChanged += new System.EventHandler(this.TxtCanTextChanged);
			// 
			// txtTo
			// 
			this.txtTo.Location = new System.Drawing.Point(313, 281);
			this.txtTo.Name = "txtTo";
			this.txtTo.Size = new System.Drawing.Size(100, 26);
			this.txtTo.TabIndex = 13;
			// 
			// lvReg
			// 
			this.lvReg.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.Postre,
									this.Tipo,
									this.Precio,
									this.Cantidad,
									this.Total});
			this.lvReg.GridLines = true;
			this.lvReg.Location = new System.Drawing.Point(0, 339);
			this.lvReg.Name = "lvReg";
			this.lvReg.Size = new System.Drawing.Size(860, 192);
			this.lvReg.TabIndex = 14;
			this.lvReg.UseCompatibleStateImageBehavior = false;
			this.lvReg.View = System.Windows.Forms.View.Details;
			// 
			// Postre
			// 
			this.Postre.Text = "Postre";
			this.Postre.Width = 127;
			// 
			// Tipo
			// 
			this.Tipo.Text = "Tipo";
			this.Tipo.Width = 135;
			// 
			// Precio
			// 
			this.Precio.Text = "Precio";
			this.Precio.Width = 124;
			// 
			// Cantidad
			// 
			this.Cantidad.Text = "Cantidad";
			this.Cantidad.Width = 133;
			// 
			// Total
			// 
			this.Total.Text = "Total";
			this.Total.Width = 139;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(339, 558);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 15;
			this.label5.Text = "Descuento:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(115, 558);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 16;
			this.label6.Text = "Subtotal:";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(596, 555);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(118, 23);
			this.label7.TabIndex = 17;
			this.label7.Text = "Importe Neto:";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(578, 595);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(136, 23);
			this.label8.TabIndex = 18;
			this.label8.Text = "Importe Pagado:";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(614, 642);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 19;
			this.label9.Text = "Cambio:";
			// 
			// txtNeto
			// 
			this.txtNeto.Location = new System.Drawing.Point(720, 552);
			this.txtNeto.Name = "txtNeto";
			this.txtNeto.Size = new System.Drawing.Size(100, 26);
			this.txtNeto.TabIndex = 20;
			// 
			// txtPa
			// 
			this.txtPa.Location = new System.Drawing.Point(720, 592);
			this.txtPa.Name = "txtPa";
			this.txtPa.Size = new System.Drawing.Size(100, 26);
			this.txtPa.TabIndex = 21;
			this.txtPa.TextChanged += new System.EventHandler(this.TxtPaTextChanged);
			// 
			// txtCam
			// 
			this.txtCam.Location = new System.Drawing.Point(720, 639);
			this.txtCam.Name = "txtCam";
			this.txtCam.Size = new System.Drawing.Size(100, 26);
			this.txtCam.TabIndex = 22;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(115, 635);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 27);
			this.button1.TabIndex = 23;
			this.button1.Text = "Guardar";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(230, 635);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 27);
			this.button2.TabIndex = 24;
			this.button2.Text = "Borrar";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(330, 635);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 27);
			this.button3.TabIndex = 25;
			this.button3.Text = "Imprimir";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// btnAgre
			// 
			this.btnAgre.Location = new System.Drawing.Point(470, 226);
			this.btnAgre.Name = "btnAgre";
			this.btnAgre.Size = new System.Drawing.Size(162, 38);
			this.btnAgre.TabIndex = 26;
			this.btnAgre.Text = "Agregar Producto";
			this.btnAgre.UseVisualStyleBackColor = true;
			this.btnAgre.Click += new System.EventHandler(this.BtnAgreClick);
			// 
			// btnEli
			// 
			this.btnEli.Location = new System.Drawing.Point(470, 275);
			this.btnEli.Name = "btnEli";
			this.btnEli.Size = new System.Drawing.Size(162, 38);
			this.btnEli.TabIndex = 27;
			this.btnEli.Text = "Eliminar Producto";
			this.btnEli.UseVisualStyleBackColor = true;
			this.btnEli.Click += new System.EventHandler(this.BtnEliClick);
			// 
			// txtDes
			// 
			this.txtDes.Location = new System.Drawing.Point(445, 555);
			this.txtDes.Name = "txtDes";
			this.txtDes.Size = new System.Drawing.Size(100, 26);
			this.txtDes.TabIndex = 28;
			this.txtDes.TextChanged += new System.EventHandler(this.TxtDesTextChanged);
			// 
			// txtSub
			// 
			this.txtSub.Location = new System.Drawing.Point(221, 555);
			this.txtSub.Name = "txtSub";
			this.txtSub.Size = new System.Drawing.Size(100, 26);
			this.txtSub.TabIndex = 29;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(80, 140);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(123, 23);
			this.label10.TabIndex = 30;
			this.label10.Text = "Tipo de Postre:";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(660, 125);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(170, 171);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 31;
			this.pictureBox2.TabStop = false;
			// 
			// cmbSal
			// 
			this.cmbSal.FormattingEnabled = true;
			this.cmbSal.Items.AddRange(new object[] {
									"Pretzel",
									"Crepa salada",
									"Muffins salados",
									"Buñuelos salados",
									"Galletas saladas"});
			this.cmbSal.Location = new System.Drawing.Point(511, 159);
			this.cmbSal.Name = "cmbSal";
			this.cmbSal.Size = new System.Drawing.Size(121, 28);
			this.cmbSal.TabIndex = 32;
			this.cmbSal.Visible = false;
			this.cmbSal.SelectedIndexChanged += new System.EventHandler(this.CmbSalSelectedIndexChanged);
			// 
			// cmbDul
			// 
			this.cmbDul.FormattingEnabled = true;
			this.cmbDul.Items.AddRange(new object[] {
									"Helado",
									"Pastel",
									"Pay de queso",
									"Crepa dulce",
									"Brownie de chocolate"});
			this.cmbDul.Location = new System.Drawing.Point(511, 159);
			this.cmbDul.Name = "cmbDul";
			this.cmbDul.Size = new System.Drawing.Size(121, 28);
			this.cmbDul.TabIndex = 33;
			this.cmbDul.Visible = false;
			this.cmbDul.SelectedIndexChanged += new System.EventHandler(this.CmbDulSelectedIndexChanged);
			// 
			// txtPre
			// 
			this.txtPre.Location = new System.Drawing.Point(12, 281);
			this.txtPre.Name = "txtPre";
			this.txtPre.Size = new System.Drawing.Size(100, 26);
			this.txtPre.TabIndex = 35;
			// 
			// Postres_Pasteleria_
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(857, 687);
			this.Controls.Add(this.txtPre);
			this.Controls.Add(this.cmbDul);
			this.Controls.Add(this.cmbSal);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtSub);
			this.Controls.Add(this.txtDes);
			this.Controls.Add(this.btnEli);
			this.Controls.Add(this.btnAgre);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtCam);
			this.Controls.Add(this.txtPa);
			this.Controls.Add(this.txtNeto);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lvReg);
			this.Controls.Add(this.txtTo);
			this.Controls.Add(this.txtCan);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmbSelec);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.rdbSal);
			this.Controls.Add(this.rdbDul);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Postres_Pasteleria_";
			this.Text = "Pasteleria \"Biscocho Sabroso\"";
			this.Load += new System.EventHandler(this.Postres_Pasteleria_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ColumnHeader Total;
		private System.Windows.Forms.ColumnHeader Cantidad;
		private System.Windows.Forms.ColumnHeader Precio;
		private System.Windows.Forms.ColumnHeader Tipo;
		private System.Windows.Forms.ColumnHeader Postre;
		private System.Windows.Forms.TextBox txtPre;
		private System.Windows.Forms.ComboBox cmbDul;
		private System.Windows.Forms.ComboBox cmbSal;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtSub;
		private System.Windows.Forms.TextBox txtDes;
		private System.Windows.Forms.Button btnEli;
		private System.Windows.Forms.Button btnAgre;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtCam;
		private System.Windows.Forms.TextBox txtPa;
		private System.Windows.Forms.TextBox txtNeto;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ListView lvReg;
		private System.Windows.Forms.TextBox txtTo;
		private System.Windows.Forms.TextBox txtCan;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbSelec;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rdbSal;
		private System.Windows.Forms.RadioButton rdbDul;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
