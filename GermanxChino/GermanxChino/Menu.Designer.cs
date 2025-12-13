/*
 * Creado por SharpDevelop.
 * Usuario: tijam
 * Fecha: 06/12/2025
 * Hora: 07:39 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace GermanxChino
{
	partial class Menu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tolPasteleria = new System.Windows.Forms.ToolStripButton();
			this.tolEmpleados = new System.Windows.Forms.ToolStripButton();
			this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tolMas = new System.Windows.Forms.ToolStripButton();
			this.tolSalir = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.tolPasteleria,
									this.tolEmpleados,
									this.toolStripSplitButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(763, 27);
									this.tolMas,
									this.tolSalir});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1113, 27);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tolPasteleria
			// 
			this.tolPasteleria.ForeColor = System.Drawing.SystemColors.ControlText;
			this.tolPasteleria.Image = ((System.Drawing.Image)(resources.GetObject("tolPasteleria.Image")));
			this.tolPasteleria.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tolPasteleria.Name = "tolPasteleria";
			this.tolPasteleria.Size = new System.Drawing.Size(92, 24);
			this.tolPasteleria.Text = "Pasteleria";
			this.tolPasteleria.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.tolPasteleria.Click += new System.EventHandler(this.TolPasteleriaClick);
			// 
			// tolEmpleados
			// 
			this.tolEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("tolEmpleados.Image")));
			this.tolEmpleados.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tolEmpleados.Name = "tolEmpleados";
			this.tolEmpleados.Size = new System.Drawing.Size(103, 24);
			this.tolEmpleados.Text = "Empleados";
			this.tolEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.tolEmpleados.Click += new System.EventHandler(this.TolEmpleadosClick);
			// 
			// toolStripSplitButton1
			// 
			this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.salirToolStripMenuItem});
			this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
			this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButton1.Name = "toolStripSplitButton1";
			this.toolStripSplitButton1.Size = new System.Drawing.Size(97, 24);
			this.toolStripSplitButton1.Text = "Archivos";
			this.toolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
			// tolMas
			// 
			this.tolMas.Image = ((System.Drawing.Image)(resources.GetObject("tolMas.Image")));
			this.tolMas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.tolMas.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tolMas.Name = "tolMas";
			this.tolMas.Size = new System.Drawing.Size(120, 24);
			this.tolMas.Text = "Mas opciones";
			this.tolMas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.tolMas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.tolMas.Click += new System.EventHandler(this.TolMasClick);
			// 
			// tolSalir
			// 
			this.tolSalir.Image = ((System.Drawing.Image)(resources.GetObject("tolSalir.Image")));
			this.tolSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tolSalir.Name = "tolSalir";
			this.tolSalir.Size = new System.Drawing.Size(58, 24);
			this.tolSalir.Text = "Salir";
			this.tolSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.tolSalir.Click += new System.EventHandler(this.TolSalirClick);
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(1113, 673);
			this.Controls.Add(this.toolStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IsMdiContainer = true;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Menu";
			this.Text = "Menu";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
		private System.Windows.Forms.ToolStripButton tolMas;
		private System.Windows.Forms.ToolStripButton tolSalir;
		private System.Windows.Forms.ToolStripButton tolEmpleados;
		private System.Windows.Forms.ToolStripButton tolPasteleria;
		private System.Windows.Forms.ToolStrip toolStrip1;
	}
}
