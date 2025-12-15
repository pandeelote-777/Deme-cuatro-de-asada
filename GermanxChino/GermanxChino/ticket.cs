/*
 * Creado por SharpDevelop.
 * Usuario: a4dew
 * Fecha: 10/12/2025
 * Hora: 05:31 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GermanxChino
{
	/// <summary>
	/// Description of ticket.
	/// </summary>
	public partial class ticket : Form
	{
		public ticket()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public string sub
		{
			set{lblSub.Text = value;}
		}
		
		public string de
		{
			set{lblDes.Text = value;}
		}
		
		public string tol
		{
			set{lblTo.Text = value;}
		}
		
		public string pa
		{
			set{lblPa.Text = value;}
		}
		
		public string ca
		{
			set{lblCa.Text = value;}
		}
		void TicketLoad(object sender, EventArgs e)
		{
			txtFe.Text=DateTime.Today.Date.ToString("d");
			lvPas.HideSelection=false;
			lvPas.MultiSelect=false;

		}
		
		void BtnRegreClick(object sender, EventArgs e)
		{
			Postres_Pasteleria_ f = new Postres_Pasteleria_();
			f.Show();
			this.Close();
		}
	}
}
