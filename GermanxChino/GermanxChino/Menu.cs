/*
 * Creado por SharpDevelop.
 * Usuario: tijam
 * Fecha: 13/12/2025
 * Hora: 03:20 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GermanxChino
{
	/// <summary>
	/// Description of Menu.
	/// </summary>
	public partial class Menu : Form
	{
		public Menu()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ToolStripButton1Click(object sender, EventArgs e)
		{
			cerAb(new Empleados());
		}
		
		void TolPasClick(object sender, EventArgs e)
		{
			cerAb(new Postres_Pasteleria_());
		}
		
		void TolOpcClick(object sender, EventArgs e)
		{
			cerAb(new SegundoMenu());
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			DialogResult repuesta =MessageBox.Show("¿Estas seguro que quieres salir?","Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
			if(repuesta==DialogResult.Yes){
				Application.Exit();
			}
		}
		
		void TolBoleClick(object sender, EventArgs e)
		{
			cerAb(new Boleta());
		}
		
		void ToolAcerClick(object sender, EventArgs e)
		{
			cerAb(new AcercaDe());
		}
		//Metodo para serrar los formularios cuando se ponga otro y poner el otro
		void cerAb(Form cer){
			foreach (Form f in this.MdiChildren) {
				f.Close();
			}
			
			cer.MdiParent=this;
			cer.WindowState= FormWindowState.Maximized;
			cer.Show();
		}

	}
}
