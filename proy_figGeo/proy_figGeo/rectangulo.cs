/*
 * Created by SharpDevelop.
 * User: LAB_3-PC
 * Date: 14/03/2024
 * Time: 20:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace proy_figGeo
{
	/// <summary>
	/// Description of rectangulo.
	/// </summary>
	public class rectangulo:Figura_Geometrica
	{
		protected int bace;
		protected int altura;
		public rectangulo():base() //CONSTRUCTOR
		{
			bace=7;
			altura=4;
		}
		/*
		public rectangulo(string color):base(color) //metodos con diferentes convinaciones
		{
			bace=6;
			altura=10;
		}
		
		public rectangulo(int ba):base(){
			bace=ba;
			altura=ba;
		}
		
		public rectangulo(string color,int ba):base(){
			bace=ba;
			altura=ba;
		}
		public rectangulo(int ba, string color):base(){
			bace=ba;
			altura=ba;
		}
		public rectangulo(int bace, int altura):base(){
			this.bace=bace;
			this.altura=altura;
		}
		public rectangulo(string color, int bace, int altura):base(){
			this.bace=bace;
			this.altura=altura;
		}
		public rectangulo(int bace, string color,int altura):base(){
			this.bace=bace;
			this.altura=altura;
		}
		
		public rectangulo(int bace, int altura,string color):base(){
			this.bace=bace;
			this.altura=altura;
		}
		
		
		*/
		
		
		
		
		
		
		
		
		
		
		public void leer(){
			Console.WriteLine("--INGRESAR DATOS DE	L RECTANGULO -- ");
			base.Leer();
			Console.Write("INGRESE BASE:  ");
			bace = int.Parse(Console.ReadLine());
			Console.WriteLine();
			
			Console.Write("INGRESE LA ALTURA:  ");
			altura = int.Parse(Console.ReadLine());
			Console.WriteLine();
		}
		public void mostrar(){
			Console.WriteLine("--MOSTRAR DATOS DEL RECTANGULO--");
			base.Mostrar();
			Console.WriteLine("lado: "+bace);
			Console.WriteLine("lado: "+altura);
			Console.WriteLine();
		}
		
		
		public int area(){
			return bace*altura;
		}
		
		public void perimetro(){
			
			Console.WriteLine("perimetro del rectangulo es:  "+(2*bace+2*altura));
		}
//cual es el mayor area entre cuad5rado y rectangulo
		public void mayorarea_rc(Cuadrado x){//metodo llamando objeto
	if(x.area()>area())
		Console.WriteLine("area del cuadrado gana");
			else
			Console.WriteLine("el rectangulo gana");
		}
		
		
		
		
		
	}
}
