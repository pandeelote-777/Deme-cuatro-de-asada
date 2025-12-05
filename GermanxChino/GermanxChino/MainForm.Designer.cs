/*
 * Creado por SharpDevelop.
 * Usuario: andre
 * Fecha: 04/12/2025
 * Hora: 06:32 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace GermanxChino
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUsiario = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtContraseña = new System.Windows.Forms.TextBox();
			this.btnEntrar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(285, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Login";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(245, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Usuario:";
			// 
			// txtUsiario
			// 
			this.txtUsiario.Location = new System.Drawing.Point(330, 54);
			this.txtUsiario.Name = "txtUsiario";
			this.txtUsiario.Size = new System.Drawing.Size(151, 26);
			this.txtUsiario.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(245, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Contraseña:";
			// 
			// txtContraseña
			// 
			this.txtContraseña.Location = new System.Drawing.Point(330, 83);
			this.txtContraseña.Name = "txtContraseña";
			this.txtContraseña.Size = new System.Drawing.Size(151, 26);
			this.txtContraseña.TabIndex = 4;
			// 
			// btnEntrar
			// 
			this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnEntrar.Location = new System.Drawing.Point(378, 122);
			this.btnEntrar.Name = "btnEntrar";
			this.btnEntrar.Size = new System.Drawing.Size(103, 31);
			this.btnEntrar.TabIndex = 5;
			this.btnEntrar.Text = "Entrar";
			this.btnEntrar.UseVisualStyleBackColor = false;
			this.btnEntrar.Click += new System.EventHandler(this.BtnEntrarClick);
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSalir.Location = new System.Drawing.Point(245, 122);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(97, 31);
			this.btnSalir.TabIndex = 6;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 7);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(211, 179);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Cyan;
			this.ClientSize = new System.Drawing.Size(549, 198);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnEntrar);
			this.Controls.Add(this.txtContraseña);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtUsiario);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "GermanxChino";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnEntrar;
		private System.Windows.Forms.TextBox txtContraseña;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtUsiario;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
