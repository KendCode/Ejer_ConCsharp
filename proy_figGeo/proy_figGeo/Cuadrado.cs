/*
 * Created by SharpDevelop.
 * User: LAB_3-PC
 * Date: 12/03/2024
 * Time: 20:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace proy_figGeo
{
	/// <summary>
	/// Description of Cuadrado.
	/// </summary>
	/// 
	
	
	//EN CLASES HEREDADAS ULTIMAS SOLO LOS ATRIBUTOS SON PROTEGIDAS
	//LOS METODOS, AL SER LA CLASSE QUE SERA LLAMADA DESDE EL PROGRAMA PRINCIPAL DEBE SER PROTEGIDAS
	public class Cuadrado:Figura_Geometrica
	{
		protected int lado;
		public Cuadrado():base(){
			lado=5;
		}
		//sobrecarga CONSTRUCTORES con las diferentes convinaciones dede 0 parametros hasta la acntida de convinaciones que se pueda
		
		
		public Cuadrado(string color):base(color){
			lado=5;
		}
		
		public Cuadrado(int lado):base(){
			this.lado=lado;
		}
		
		public Cuadrado(string color, int lado):base(color){
			this.lado=lado;
		}
		
		
		public Cuadrado(int lado, string color):base(color){
			this.lado=lado;
		}
		
		
		
		
		
		public void leer(){
			Console.WriteLine("--INGRESAR DATOS DE CUADRADO -- ");
			base.Leer();
			Console.Write("INGRESE EL VALOR DE LADO:  ");
			lado = int.Parse(Console.ReadLine());
			Console.WriteLine();
			
		}
		public void mostrar(){
			Console.WriteLine("--MOSTRAR DATOS DEL CUADRADO--");
			base.Mostrar();
			Console.WriteLine("lado: "+lado);
			Console.WriteLine();
		}
		
		
		//HALLAR EL AREA DE UN CUADRADO
		public int area(){
			return lado*lado;
		}
		
		//hallar el perimetro de un cuadrado
		public void perimetro(){
			Console.WriteLine("perimetro del cuadrado:  "+4*lado);
		}
		
		public void mayorarea_crt(rectangulo y,triangulo z){//metodo llamando objeto
			
			if(y.area()>z.area()&&y.area()> area())
		Console.WriteLine("area del rectangulo gana");
			else
				if(z.area()>y.area()&&z.area()>area())
		Console.WriteLine("area del triangulo gana");
			else
			Console.WriteLine("area del cuadrado gana");
		}
		
		
		
	
		}
		
		
		
		
		
		
		
		
		
		
		
		
		
		
	}
//}
