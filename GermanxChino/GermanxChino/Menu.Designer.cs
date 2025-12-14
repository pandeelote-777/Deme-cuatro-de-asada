/*
 * Creado por SharpDevelop.
 * Usuario: tijam
 * Fecha: 13/12/2025
 * Hora: 03:20 p. m.
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
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.tolPas = new System.Windows.Forms.ToolStripButton();
			this.tolBole = new System.Windows.Forms.ToolStripButton();
			this.tolOpc = new System.Windows.Forms.ToolStripButton();
			this.toolAcer = new System.Windows.Forms.ToolStripButton();
			this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripButton1,
									this.tolPas,
									this.tolBole,
									this.tolOpc,
									this.toolAcer,
									this.toolStripSplitButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(849, 27);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(103, 24);
			this.toolStripButton1.Text = "Empleados";
			this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1Click);
			// 
			// tolPas
			// 
			this.tolPas.Image = ((System.Drawing.Image)(resources.GetObject("tolPas.Image")));
			this.tolPas.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tolPas.Name = "tolPas";
			this.tolPas.Size = new System.Drawing.Size(92, 24);
			this.tolPas.Text = "Pasteleria";
			this.tolPas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.tolPas.Click += new System.EventHandler(this.TolPasClick);
			// 
			// tolBole
			// 
			this.tolBole.Image = ((System.Drawing.Image)(resources.GetObject("tolBole.Image")));
			this.tolBole.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tolBole.Name = "tolBole";
			this.tolBole.Size = new System.Drawing.Size(186, 24);
			this.tolBole.Text = "Boleta de calificaciones";
			this.tolBole.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.tolBole.Click += new System.EventHandler(this.TolBoleClick);
			// 
			// tolOpc
			// 
			this.tolOpc.Image = ((System.Drawing.Image)(resources.GetObject("tolOpc.Image")));
			this.tolOpc.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tolOpc.Name = "tolOpc";
			this.tolOpc.Size = new System.Drawing.Size(127, 24);
			this.tolOpc.Text = "Mas opcciones";
			this.tolOpc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.tolOpc.Click += new System.EventHandler(this.TolOpcClick);
			// 
			// toolAcer
			// 
			this.toolAcer.Image = ((System.Drawing.Image)(resources.GetObject("toolAcer.Image")));
			this.toolAcer.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolAcer.Name = "toolAcer";
			this.toolAcer.Size = new System.Drawing.Size(104, 24);
			this.toolAcer.Text = "Acerca de...";
			this.toolAcer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.toolAcer.Click += new System.EventHandler(this.ToolAcerClick);
			// 
			// toolStripSplitButton1
			// 
			this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.salirToolStripMenuItem});
			this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
			this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButton1.Name = "toolStripSplitButton1";
			this.toolStripSplitButton1.Size = new System.Drawing.Size(91, 24);
			this.toolStripSplitButton1.Text = "Archivo";
			this.toolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(849, 316);
			this.Controls.Add(this.toolStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IsMdiContainer = true;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Menu";
			this.Text = "Menu";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
		private System.Windows.Forms.ToolStripButton toolAcer;
		private System.Windows.Forms.ToolStripButton tolOpc;
		private System.Windows.Forms.ToolStripButton tolBole;
		private System.Windows.Forms.ToolStripButton tolPas;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStrip toolStrip1;
	}
}
