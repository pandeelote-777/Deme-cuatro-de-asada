/*
 * Creado por SharpDevelop.
 * Usuario: andre
 * Fecha: 11/12/2025
 * Hora: 04:01 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GermanxChino
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class SegundoMenu : Form
	{
		public SegundoMenu()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			Close();
		}
		
		public void ApagarBotones(){
			button1.Visible=false;
			button2.Visible=false;
			button3.Visible=false;
			button4.Visible=false;
			button5.Visible=false;
			button6.Visible=false;
			button7.Visible=false;
			button8.Visible=false;
			button9.Visible=false;
			button10.Visible=false;
			button11.Visible=false;
			button12.Visible=false;
			button13.Visible=false;
			button14.Visible=false;
			pbImagen.Visible=false;
		}
		public void IngresarUnDato(){
			txt1.Visible=true;
			txt2.Visible=false;
			txt3.Visible=false;
			txt1.Text="";
			lbl2.Text="";
			lbl3.Text="";
			lbl4.Text="";
		}
		public void IngresarDosDatos(){
			txt1.Visible=true;
			txt2.Visible=true;
			txt3.Visible=false;
			txt1.Text="";
			txt2.Text="";
			txt3.Text="";
			lbl3.Text="";
			lbl4.Text="";
		}
		
		void LongitudToolStripMenuItemClick(object sender, EventArgs e)
		{
			ApagarBotones();
			IngresarUnDato();
		    lbl1.Text= "Ingresar Kilometros:";
		    button1.Visible=true;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			double m,b;
			b = double.Parse(txt1.Text);
		    m = b/1.609;
		    lbl2.Text="Millas: "+m.ToString();
				
			
		}
		
		void MasaToolStripMenuItemClick(object sender, EventArgs e)
		{
			ApagarBotones();
			IngresarUnDato();
			lbl1.Text= "Ingresar kilogramos:";
		    button2.Visible=true;
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			double m,b;
			b = double.Parse(txt1.Text);
		    m = b*2.205;
		    lbl2.Text="Libras: "+m.ToString();
		}
		
		void TemperaturaToolStripMenuItemClick(object sender, EventArgs e)
		{
			ApagarBotones();
			IngresarUnDato();
			lbl1.Text= "Ingresar grados celcius:";
		    button3.Visible=true;
		}
		void Button3Click(object sender, EventArgs e)
		{
			double m,b;
			b = double.Parse(txt1.Text);
		    m = (b*9/5) + 32;
		    lbl2.Text="Grados Fahrenheit: "+m.ToString();
		}
		
		void TiempoToolStripMenuItemClick(object sender, EventArgs e)
		{
			ApagarBotones();
			IngresarUnDato();
			lbl1.Text= "Ingresar tiempo en horas:";
		    button4.Visible=true;
		}
		void Button4Click(object sender, EventArgs e)
		{
			double m,b;
			b = double.Parse(txt1.Text);
		    m = b*3600;
		    lbl2.Text="Segundos: "+m.ToString();
		}
		
		
		void FactorialToolStripMenuItemClick(object sender, EventArgs e)
		{
			ApagarBotones();
			IngresarUnDato();
			lbl1.Text= "Ingresar numero:";
		    button5.Visible=true;
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			double m,b;
			m=1;
			b = double.Parse(txt1.Text);
			for ( int i=1; i<=b; i++){
				m = m*i;
			}
		    lbl2.Text="Factorial: "+m.ToString();
		}
		
		void CuadradoToolStripMenuItemClick(object sender, EventArgs e)
		{
			ApagarBotones();
			IngresarUnDato();
			pbImagen.Visible=true;
			lbl1.Text= "Ingresar medida de lado:";
		    button6.Visible=true;
		    pbImagen.Image=Imagenes.Rectangulo;
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			double m,b;
			b = double.Parse(txt1.Text);
			m = b*b;
		    lbl2.Text="Area: "+m.ToString();
		}
		
		void CircunferenciaToolStripMenuItemClick(object sender, EventArgs e)
		{
			ApagarBotones();
			IngresarUnDato();
			pbImagen.Visible=true;
			lbl1.Text= "Ingresar radio:";
		    button7.Visible=true;
		    pbImagen.Image=Imagenes.Circunferencia;
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			double m,b;
			b = double.Parse(txt1.Text);
			m = b*2*3.1416;
		    lbl2.Text="Perimetro: "+m.ToString();
		}
		
		void CuboToolStripMenuItemClick(object sender, EventArgs e)
		{
			ApagarBotones();
			IngresarUnDato();
			pbImagen.Visible=true;
			lbl1.Text= "Ingresar medida del lado:";
		    button8.Visible=true;
		    pbImagen.Image=Imagenes.Cubo;
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			double m,b;
			b = double.Parse(txt1.Text);
			m = b*b*b;
		    lbl2.Text="Volumen: "+m.ToString();
		}
		
		
		void FigonnaciToolStripMenuItemClick(object sender, EventArgs e)
		{
			ApagarBotones();
			IngresarUnDato();
			lbl1.Text= "Ingresar un numero:";
		    button9.Visible=true;
		}
		
		void Button9Click(object sender, EventArgs e)
		{
			lbl2.Text="Serie Figonnaci: ";
			int b, n=1, m=0;
			b = int.Parse(txt1.Text);
    		for (int i=0; i<b; i++){
				if(i%2==0){
			    	lbl2.Text+=m.ToString()+" ";
			   		n+=m;
				}else{
			   		lbl2.Text+=n.ToString()+" ";
			    	m+=n;
				}
			}
		}
		
		void RectanguloToolStripMenuItemClick(object sender, EventArgs e)
		{
			ApagarBotones();
			IngresarDosDatos();
			pbImagen.Visible=true;
			lbl1.Text= "Ingresar medida de la base:";
		    lbl2.Text="Ingresar medida de la altura:";
		    button10.Visible=true;
		    pbImagen.Image=Imagenes.Cuadrado;
		}
		
		void Button10Click(object sender, EventArgs e)
		{
			double b, h, a;
			b = double.Parse(txt1.Text);
			h = double.Parse(txt2.Text);
			a = h*b;
			lbl3.Text="Area: "+a.ToString();
		}
		
		void TrianguloToolStripMenuItemClick(object sender, EventArgs e)
		{
			ApagarBotones();
			IngresarDosDatos();
			pbImagen.Visible=true;
			lbl1.Text= "Ingresar medida de la base:";
		    lbl2.Text="Ingresar medida de la altura:";
		    button11.Visible=true;
		    pbImagen.Image=Imagenes.Triangulo;
		}
		
		void Button11Click(object sender, EventArgs e)
		{
			double b, h, a;
			b = double.Parse(txt1.Text);
			h = double.Parse(txt2.Text);
			a = (h*b)/2;
			lbl3.Text="Area: "+a.ToString();
		}
		
		void TrapecioToolStripMenuItemClick(object sender, EventArgs e)
		{
			ApagarBotones();
			IngresarDosDatos();
			pbImagen.Visible=true;
			lbl1.Text= "Ingresar medida de la base mayor:";
		    lbl2.Text="Ingresar medida de la base menor:";
		    lbl3.Text="Ingresar medida de un lado:";
		    button12.Visible=true;
		    txt3.Visible=true;
		    pbImagen.Image=Imagenes.Trapecio;
		}
		
		void Button12Click(object sender, EventArgs e)
		{
			double a, b, c, p;
			a = double.Parse(txt1.Text);
			b = double.Parse(txt2.Text);
			c = double.Parse(txt3.Text);
			p = a+b+c+c;
			lbl4.Text="Perimetro: "+p.ToString();
		}
		
		void EsferaToolStripMenuItemClick(object sender, EventArgs e)
		{
			ApagarBotones();
			IngresarUnDato();
			pbImagen.Visible=true;
			lbl1.Text= "Ingresar radio:";
		    button13.Visible=true;
		    pbImagen.Image=Imagenes.Esfera;
		}
		
		void Button13Click(object sender, EventArgs e)
		{
			double m, b;
			b = double.Parse(txt1.Text);
			m = (4/3)*(3.1416)*(b*b*b);
		    lbl2.Text="Volumen: "+m.ToString();
		}
		
		void PiramideToolStripMenuItemClick(object sender, EventArgs e)
		{
			ApagarBotones();
			IngresarDosDatos();
			pbImagen.Visible=true;
			lbl1.Text= "Ingresar Area de la base:";
		    lbl2.Text="Ingresar altura:";
		    button14.Visible=true;
		    pbImagen.Image=Imagenes.Piramide;
		}
		
		void Button14Click(object sender, EventArgs e)
		{
			double a, ab, v;
			ab = double.Parse(txt1.Text);
			a = double.Parse(txt2.Text);
			v = (a*ab)/3;
			lbl3.Text="Volumen: "+v.ToString();
		}
		
	}
}
