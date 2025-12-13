/*
 * Creado por SharpDevelop.
 * Usuario: tijam
 * Fecha: 06/12/2025
 * Hora: 07:39 p. m.
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
		Postres_Pasteleria_ p = new Postres_Pasteleria_();
		Empleados Em = new Empleados();
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
		void TolPasteleriaClick(object sender, EventArgs e)
		{
			p.MdiParent=this;
			p.WindowState=FormWindowState.Maximized;
			p.Show();
			this.Em.Hide();
		}
		
		void TolEmpleadosClick(object sender, EventArgs e)
		{
			Em.MdiParent=this;
			p.WindowState=FormWindowState.Maximized;
			Em.Show();
			this.p.Hide();
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
