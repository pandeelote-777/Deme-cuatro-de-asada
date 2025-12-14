/*
 * Creado por SharpDevelop.
 * Usuario: tijam
 * Fecha: 13/12/2025
 * Hora: 06:02 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GermanxChino
{
	/// <summary>
	/// Description of Acerca.
	/// </summary>
	public partial class Acerca : Form
	{
		public Acerca()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
