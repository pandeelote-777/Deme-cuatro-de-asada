/*
 * Creado por SharpDevelop.
 * Usuario: tijam
 * Fecha: 06/12/2025
 * Hora: 09:07 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GermanxChino
{
	/// <summary>
	/// Description of Empleados.
	/// </summary>
	public partial class Empleados : Form
	{
		public Empleados()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnQuitarClick(object sender, EventArgs e)
		{
			pictureBox1.Image=null;
		}
		
		void BtnActualizarClick(object sender, EventArgs e)
		{
			OpenFileDialog imagen = new OpenFileDialog();
			imagen.Filter="Archivos de imagen |*.jpg; *.jpeg; *.png; *.gif; *.bmp";
			
			if(imagen.ShowDialog() == DialogResult.OK){
				string ima = imagen.FileName;
				pictureBox1.Image= Image.FromFile(ima);
			}
	
		}
	}
}
