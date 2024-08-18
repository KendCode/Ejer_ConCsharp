/*
 * Created by SharpDevelop.
 * User: LAB_3-PC
 * Date: 14/03/2024
 * Time: 20:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace proy_figGeo
{
	/// <summary>
	/// Description of triangulo.
	/// </summary>
	public class triangulo:Figura_Geometrica
	{
		//ATRIBUTOS PROPIUOS DE LA CLASE
		protected int bace;
		protected int altura;
		protected int angulo;
		
		public triangulo():base()//CONSTRUCTOR
		{
			bace= 7;
			altura = 4;
			angulo = 45;
		}	
			public void leer(){
				Console.WriteLine("--INGRESAR DATOS DEL TRIUANGULO -- ");
				base.Leer();
				Console.Write("INGRESE BASE:  ");
				bace = int.Parse(Console.ReadLine());
				Console.WriteLine();
				
				Console.Write("INGRESE LA ALTURA:  ");
				altura = int.Parse(Console.ReadLine());
				Console.WriteLine();
				
				Console.Write("INGRESE LA ANGULO:  ");
				angulo = int.Parse(Console.ReadLine());
				Console.WriteLine();
				
			}
			public void mostrar(){
				Console.WriteLine("--MOSTRAR DATOS DEL TRIANGULO--");
				base.Mostrar();
				Console.WriteLine("base: "+bace);
				Console.WriteLine("altura: "+altura);
				Console.WriteLine("angulo: "+angulo);
				Console.WriteLine();
				
			}
		//otros metodos
		
		
		public double area(){
			return(double) (bace*altura)/2;
		}
		
		
			public void menorarea_crt(rectangulo y,Cuadrado z){//metodo llamando objeto
			
			if(y.area()<z.area()&&y.area()< area())
		Console.WriteLine("el area del triangulo es menor");
			else
				if(z.area()<y.area()&&z.area()<area())
		Console.WriteLine("area del cuadrado es menor");
			else
			Console.WriteLine("area del rectangulo es menor");
		}
		
		
		
		
	}
}
