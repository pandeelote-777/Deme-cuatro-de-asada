/*
 * Creado por SharpDevelop.
 * Usuario: CC_PC20
 * Fecha: 05/12/2025
 * Hora: 02:58 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace GermanxChino
{
	/// <summary>
	/// Description of Postres_Pasteleria_.
	/// </summary>
	public partial class Postres_Pasteleria_ : Form
	{
		double pre, st=0, imn;
		public Postres_Pasteleria_()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void RdbDulCheckedChanged(object sender, EventArgs e)
		{
			rdbDul.ForeColor=System.Drawing.Color.Green;
			rdbSal.ForeColor=System.Drawing.Color.Red;	
			cmbDul.Visible=true;
			cmbSal.Visible=false;
		}
		
		void RdbSalCheckedChanged(object sender, EventArgs e)
		{
			rdbSal.ForeColor=System.Drawing.Color.Green;
			rdbDul.ForeColor=System.Drawing.Color.Red;
		    cmbDul.Visible=false;
			cmbSal.Visible=true;
		}
		
		void CmbDulSelectedIndexChanged(object sender, EventArgs e)
		{
			string pos = cmbDul.Text;
			if(pos.Equals("Helado")) pre=35;
			if(pos.Equals("Pastel")) pre=150;
			if(pos.Equals("Pay de queso")) pre=165;
			if(pos.Equals("Brownie de chocolate")) pre=50;
			if(pos.Equals("Crepa dulce")) pre=65;
			txtPre.Text=pre.ToString("C");
		}
		
		void Postres_Pasteleria_Load(object sender, EventArgs e)
		{
			txtPre.Text=(0).ToString("C");
			txtTo.Text=(0).ToString("C");
			txtSub.Text=(0).ToString("C");
			txtNeto.Text=(0).ToString("C");
			txtCam.Text=(0).ToString("C");
			
		}
		
		void CmbSalSelectedIndexChanged(object sender, EventArgs e)
		{
			string pos = cmbSal.Text;
			if(pos.Equals("Pretzel")) pre=45;
			if(pos.Equals("Crepa salada")) pre=75;
			if(pos.Equals("Muffins salados")) pre=80;
			if(pos.Equals("Buñuelos salados")) pre=45;
			if(pos.Equals("Galletas saladas")) pre=35;
			txtPre.Text=pre.ToString("C");
		}
		
		void BtnAgreClick(object sender, EventArgs e)
		{
			string pos="";
			if(rdbDul.Checked)
			{
				pos = cmbDul.Text;
			}
			if(rdbSal.Checked)
			{
			    pos = cmbSal.Text;
			}
			int can = Convert.ToInt32(txtCan.Text);
			double to = can*pre;
			//Impresion de resultados
			ListViewItem fila= new ListViewItem(pos);
			if(rdbDul.Checked)
				fila.SubItems.Add(rdbDul.Text);
			if(rdbSal.Checked)
				fila.SubItems.Add(rdbSal.Text);
			fila.SubItems.Add(pre.ToString("C"));
			fila.SubItems.Add(can.ToString());
			fila.SubItems.Add(to.ToString("C"));
			lvReg.Items.Add(fila);
			BtnEliClick(sender, e);
			st += to;
			txtSub.Text=st.ToString("C");
			
		}
		
		void TxtCanTextChanged(object sender, EventArgs e)
		{
			string pos="";
			if(rdbDul.Checked)
				pos = cmbDul.Text;
			if(rdbSal.Checked)
			    pos = cmbSal.Text;
			int can;
			int c;
			if(int.TryParse(txtCan.Text, out c))
			    can = c;
			else
    			can = 0;
			double to = can*pre;
			txtTo.Text=to.ToString("C");
		}
		
		void TxtDesTextChanged(object sender, EventArgs e)
		{
			int d;
			int des = Convert.ToInt32(txtDes.Text);
			if(int.TryParse(txtDes.Text, out d))
			    des = d;
			else
    			des = 0;
			imn = st-des;
			txtNeto.Text=imn.ToString("C");
		}
		
		void BtnEliClick(object sender, EventArgs e)
		{
			cmbDul.Text="";
			cmbSal.Text="";
			txtCan.Clear();
			txtTo.Text=(0).ToString("C");
			txtPre.Text=(0).ToString("C");
		}
		
		void TxtPaTextChanged(object sender, EventArgs e)
		{
			int p;
			int pag = Convert.ToInt32(txtPa.Text);
			if(int.TryParse(txtPa.Text, out p))
			    pag = p;
			else
    			pag = 0;
			double cam = pag-imn;
			txtCam.Text=cam.ToString("C");
		}
		
		void BtnImClick(object sender, EventArgs e)
		{
			ticket f = new ticket();
			f.Show();
			this.Hide();
		}
	}
}
