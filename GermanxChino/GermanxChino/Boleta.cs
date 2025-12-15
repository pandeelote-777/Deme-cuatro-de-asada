/*
 * Creado por SharpDevelop.
 * Usuario: a4dew
 * Fecha: 12/12/2025
 * Hora: 01:51 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GermanxChino
{
	/// <summary>
	/// Description of Boleta.
	/// </summary>
	public partial class Boleta : Form
	{
		double cont=0;
		double prt=0;
		public Boleta()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BoletaLoad(object sender, EventArgs e)
		{
			txtFecha.Text=DateTime.Today.Date.ToString("d");
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			txtNombre.Clear();
			txtPromedio.Clear();
			txtp3.Clear();
			txtp2.Clear();
			txtp1.Clear();
			cboAsignatura.Text="";
			cboEspecialidad.Text="";
			cboSemestre.Text="";
			txtNombre.Focus();
		}
		void BtnSalirClick(object sender, System.EventArgs e)
		{
			Close();
		}
		
		void BtnRegistrarClick(object sender, EventArgs e)
		{
			if (cboSemestre.SelectedIndex==-1 || cboEspecialidad.SelectedIndex==-1 || cboAsignatura.SelectedIndex==-1) {
			}else if (txtNombre.Text=="" || txtp1.Text=="" || txtp2.Text=="" || txtp3.Text=="") {	
			}else{
				double pf;
				cont++;
				string asignatura = cboAsignatura.Text;
				double p1 = Convert.ToInt32(txtp1.Text);
				double p2 = Convert.ToInt32(txtp2.Text);
				double p3 = Convert.ToInt32(txtp3.Text);
				double prom = (p1+p2+p3)/3;
				string ar;
				if ( prom>=6 ){
					ar = "Aprobado";
				}else{
					ar = "Reprobado";
				}
				ListViewItem fila=new ListViewItem(asignatura);
				fila.SubItems.Add(p1.ToString());
				fila.SubItems.Add(p2.ToString());
				fila.SubItems.Add(p3.ToString());
				fila.SubItems.Add(prom.ToString());
				fila.SubItems.Add(ar);
				listView1.Items.Add(fila);
				prt += prom;
				pf = prt/cont;
				txtPromedio.Text=pf.ToString();
			}
		}
	}
}
