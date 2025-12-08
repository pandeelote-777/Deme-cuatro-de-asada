/*
 * Creado por SharpDevelop.
 * Usuario: andre
 * Fecha: 04/12/2025
 * Hora: 06:32 p. m.
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
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		int c=0,f=0;
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void BtnEntrarClick(object sender, EventArgs e)
		{
			if(txtUsiario.Text=="Admin" && txtContraseña.Text=="123"){
				Menu f =new Menu();
				f.Show();
				this.Hide();
			}
			else{
				if(c<=2){
				c=c+1;
				f=4-c;
				MessageBox.Show("El usiario o la contraseña estan mal. "+"Tienes "+f.ToString()+" oportunidades");
				}else{
					if(c==3){
						Application.Exit();
					}
				}
			}
		}
	}
}
