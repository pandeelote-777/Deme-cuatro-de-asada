/*
 * Creado por SharpDevelop.
 * Usuario: tijam
 * Fecha: 06/12/2025
 * Hora: 09:07 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GermanxChino
{
	/// <summary>
	/// Description of Empleados.
	/// </summary>
	public partial class Empleados : Form
	{
		List<lista> miLista = new List<lista>();
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
			//Se busca la imagen para poner 
			OpenFileDialog imagen = new OpenFileDialog();
			imagen.Filter="Archivos de imagen |*.jpg; *.jpeg; *.png; *.gif; *.bmp";
			
			if(imagen.ShowDialog() == DialogResult.OK){
				string ima = imagen.FileName;
				pictureBox1.Image= Image.FromFile(ima);
				pictureBox1.SizeMode= PictureBoxSizeMode.Zoom;
			}
	
		}
		
		void BtnGuardarClick(object sender, EventArgs e)
		{
			//Se ve le estado
			string est="a";
			if(rdbContrato.Checked==true){
				est="Contrato";
			}else{
				if(rdbRegular.Checked==true){
					est="Regular";
				}
			}
			//Se crea la lista para guradar
			lista Empleados= new lista();
			Empleados.Codigo_de_empleado=int.Parse(txtCodigoEmpleado.Text);
			Empleados.Nombre_del_empleado=txtNombreEmpleado.Text;
			Empleados.Puesto=cboPuesto.Text;
			Empleados.Fecha_de_nacimiento=txtFechaNac.Text;
			Empleados.Sexo=cboSex.Text;
			Empleados.Estado=est;
			miLista.Add(Empleados);
			dataLista.DataSource=null;
			dataLista.DataSource=miLista;
			
			
		}
	}
}
