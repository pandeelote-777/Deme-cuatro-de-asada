/*
 * Creado por SharpDevelop.
 * Usuario: tijam
 * Fecha: 06/12/2025
 * Hora: 09:07 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using MySql.Data.MySqlClient;
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
			btnQuitar.Enabled=false;
			btnActualizar.Enabled=true;
		}
		
		void BtnActualizarClick(object sender, EventArgs e)
		{
			//Se busca la imagen para poner 
			OpenFileDialog imagen = new OpenFileDialog();
			imagen.Filter="Archivos de imagen |*.jpg; *.jpeg; *.png; *.gif; *.bmp; *.jfif";
			
			if(imagen.ShowDialog() == DialogResult.OK){
				string ima = imagen.FileName;
				pictureBox1.Image= Image.FromFile(ima);
				pictureBox1.SizeMode= PictureBoxSizeMode.Zoom;
				btnQuitar.Enabled=true;
				btnActualizar.Enabled=false;
			}
			
		}
		
		void BtnGuardarClick(object sender, EventArgs e)
		{
			//Se checa los datos
			if(validarCodigo()==false){
				return;
			}
			
			if(ValidarNombre()==false){
				return;
			}
			
			if (ValidarPuesto()==false) {
				return;
			}
			
			if (validarFecha()==false) {
				return;
			}
			
			if(validarSexo()==false){
				return;
			}
			
			if (validarEstado()==false) {
				return;
			}
			
			if (validarImagen()==false) {
				return;
			}
			
			if(validarFecha()==false){
				return;
			}
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
			Empleados.Fecha_de_nacimiento=datiFechaNac.Text;
			Empleados.Sexo=cboSex.Text;
			Empleados.Estado=est;
			miLista.Add(Empleados);
			//AgregarEmpleado();
			LimpiarControles();
			
			//Se gurda la base de datos
			
		}
		
		//Metodo para validar el Nombre
		private bool ValidarNombre()
		{
			if(string.IsNullOrEmpty(txtNombreEmpleado.Text)){
				erpHerror.SetError(txtNombreEmpleado,"Debe de ingresar el nombre del empleado");
				return false;
			}else{
				erpHerror.SetError(txtNombreEmpleado,"");
				return true;
			}
		}
		
		//Metodo para validar el codigo de empleado 
		private bool validarCodigo()
		{
			int codigo;
			if(!int.TryParse(txtCodigoEmpleado.Text, out codigo) || txtCodigoEmpleado.Text==""){
				erpHerror.SetError(txtCodigoEmpleado,"Necesitas poner el  codigo de empleado");
				txtCodigoEmpleado.Clear();
				txtCodigoEmpleado.Focus();
				return false;
			}else{
				erpHerror.SetError(txtCodigoEmpleado,"");
				return true;
			}
		}
		
		//Metodo para validar el puesto
		private bool ValidarPuesto()
		{
			if(string.IsNullOrEmpty(cboPuesto.Text)){
				erpHerror.SetError(cboPuesto,"Debes celeccionar un puesto");
				return false;
			}
			else
			{
				erpHerror.SetError(cboPuesto,"");
				return true;
			}
		}
		
		//Metodo para validar el sexo
		private bool validarSexo(){
			if (string.IsNullOrEmpty(cboSex.Text)) {
				erpHerror.SetError(cboSex,"Debes ingresar el sexo");
				return false;
			}else{
				erpHerror.SetError(cboSex,"");
				return true;
			}
		}
		
		//Metodo para validar estado
		private bool validarEstado()
		{
			if (rdbContrato.Checked || rdbRegular.Checked) {
				erpHerror.SetError(groupBox1,"");
				return true;
			}else{
				erpHerror.SetError(groupBox1,"Debes  de escoger un Estado");
				return false;
			}
		}
		
		//Metodo para validar la imagen
		private bool validarImagen()
		{
			if (pictureBox1.Image==null) {
				erpHerror.SetError(btnActualizar,"Debes de  tener una imagen");
				return false;
			}else{
				erpHerror.SetError(btnActualizar,"");
				return true;
			}
		}
		//Metodo para validar la fecha 
		private bool validarFecha()
		{
			if (datiFechaNac.Value>DateTime.Now)
			{
				erpHerror.SetError(datiFechaNac,"La fecha no puede ser futura o la de  hoy");
				return false;
				
			}else{
				if (datiFechaNac.Value.Date==DateTime.Today) {
					erpHerror.SetError(datiFechaNac,"La fecha no puede ser la de  hoy");
					return false;
				}else{
					erpHerror.SetError(datiFechaNac,"");
				return true;
				}
				
			}
		}
		//Limpiar controles
		private void LimpiarControles()
		{
			txtCodigoEmpleado.Clear();
			txtNombreEmpleado.Clear();
			cboPuesto.SelectedIndex=-1;
			cboSex.SelectedIndex=-1;
			rdbRegular.Checked=false;
			rdbContrato.Checked=false;
			pictureBox1.Image=null;
			datiFechaNac.Value=DateTime.Now;
		}
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			LimpiarControles();
		}
		
		//Elimina una fila de datos escogido
		void BtnEliminarClick(object sender, EventArgs e)
		{
			if(txtCodigoEmpleado.Text==""){
				erpHerror.SetError(txtCodigoEmpleado,"Debes de poner el codigo del empleado");
				LimpiarControles();
				txtCodigoEmpleado.Focus();
				return;
			}else{
				erpHerror.SetError(txtCodigoEmpleado,"");
				DialogResult repuesta =MessageBox.Show("¿Estas seguro que quieres el registro?","Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
				
				if(repuesta==DialogResult.Yes){
					foreach (lista Empleados in miLista) {
						if(Empleados.Codigo_de_empleado==int.Parse(txtCodigoEmpleado.Text)){
							miLista.Remove(Empleados);
							break;
						}
					}
					LimpiarControles();
					dataLista.DataSource=null;
					dataLista.DataSource=miLista;
				}
			}
		}
		//Conectar la base de datos
		public bool AgregarEmpleado(int Codigo, string Nombre, string Puesto,string Fecha_de_nacimiento,string Sexo, string Estado){
			//Crear la conexión
			MySqlConnection cn = new MySqlConnection();
			cn.ConnectionString="server=localhost; database=Proyecto_final; user=root; pwd=;";
			cn.Open();
			
			//Se agrega el registro de base de datos
			string strQl="insert into Empleados(Codigo, Nombre, Puesto, Fecha_de_nacimiento, Sexo, Estado)"+"values(@Codigo, @Nombre, @Puesto, @Fecha_de_nacimiento, @Sexo, @Estado)";
			MySqlCommand comando = new MySqlCommand(strQl, cn);
			comando.Parameters.AddWithValue("Codigo",Codigo);
			comando.Parameters.AddWithValue("Nombre",Nombre);
			comando.Parameters.AddWithValue("Puesto",Puesto);
			comando.Parameters.AddWithValue("Fecha_de_nacimiento",Fecha_de_nacimiento);
			comando.Parameters.AddWithValue("Sexo",Sexo);
			comando.Parameters.AddWithValue("Estado",Estado);
			comando.ExecuteNonQuery();
			MessageBox.Show("Empleado agregado");
			
			//Finalizamos y cerramos todo
			comando.Dispose();
			cn.Close();
			cn.Dispose();
			
			return true;
		}
	}
}
