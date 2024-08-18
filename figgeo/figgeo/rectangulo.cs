/*
 * Creado por SharpDevelop.
 * Usuario: Strix
 * Fecha: 14/03/2024
 * Hora: 20:34
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace figgeo
{
	/// <summary>
	/// Description of rectangulo.
	/// </summary>
	public class rectangulo: figuraGeometrica
	{
		//atributospropios de la clase rectangulo
		protected int bas;
		protected int altura;
		
		public rectangulo():base(){
			bas=7;
			altura=4;
			
		}
		
		public rectangulo(string color):base(color){
			bas=6;
			altura=7;
		}
		
		
		public rectangulo(int ba):base(color){
			bas=ba;
			altura=ba;
		}
		
		
		
		public rectangulo(string color,int ba):base(color){
			bas=ba;
			altura=ba;
		}
		
		
		
		public rectangulo(int ba,string color):base(color){
			bas=ba;
			altura=ba;
		}
		
		public rectangulo(int bas,int altura):base(color){
		this.bas=bas;
			this.altura=altura;
		}
		
		
		public rectangulo(string color,int bas,int altura):base(color){
			this.bas=bas;
			this.altura=altura;
		}
		
		public rectangulo(int bas,string color,int altura):base(color){
			this.bas=bas;
			this.altura=altura;
		}
		
		public rectangulo(int bas,int altura,string color):base(color){
			this.bas=bas;
			this.altura=altura; 
		}
		public void Leer(){
			Console.WriteLine("--datos del rectangulo");
			base.Leer();//esta llamando al metodo de la clase figura geometrica
		    Console.WriteLine("ingrese base ");
		    bas = int.Parse(Console.ReadLine());
			Console.Write("Ingrese altura : ");
			altura = int.Parse(Console.ReadLine());
	
}
			public void Mostrar(){
			Console.WriteLine("mostrando datos del rectangulo");
			base.Mostrar();
			Console.WriteLine("base:   "+bas);
			Console.WriteLine("altura:   "+altura);
	}
		
		public void area(){
			Console.Write("area del rectangulo es igual a"+ bas*altura);
		}
		
		public void perimetro(){
			Console.WriteLine("perimetro del rectangulo"+(2*bas+2*altura));
		}
	}
	}
	
	
