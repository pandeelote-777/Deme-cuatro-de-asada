/*
 * Creado por SharpDevelop.
 * Usuario: a4dew
 * Fecha: 15/12/2025
 * Hora: 02:35 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GermanxChino
{
	/// <summary>
	/// Description of AcercaDe.
	/// </summary>
	public partial class AcercaDe : Form
	{
		public AcercaDe()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnSalClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
