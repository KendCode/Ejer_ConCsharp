/*
 * Creado por SharpDevelop.
 * Usuario: Strix
 * Fecha: 12/03/2024
 * Hora: 20:42
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace figgeo
{
	/// <summary>
	/// Description of cuadrado.
	/// </summary>
	/// enlas clases ulktimas heredadas es publicas la principal sus atributos siempre seran de tipo privado
	public class cuadrado:figuraGeometrica
	{
		protected int lado;
		public cuadrado():base(){
			lado=5;
			
		}
		//sobrecargando constructorers
		//                donde mandas              donde llega programcs
//	public cuadrado(string color):base(color){
		//	lado=5;
			
	//	}

//	public cuadrado(int lado):base(){
		//	this.lado=lado;
			
	//	}	


//	public cuadrado(string color, int lado):base(color){
			//this es lo que manda del contructor al programa prinsipal program cs
		//	this.lado=lado;
			
		//}
		
	//	public cuadrado(int lado,string color ):base(color){
			//this es lo que manda del contructor al programa prinsipal program cs
		//	this.lado=lado;
			
		//}
		
		public cuadrado(int lado):base(){
			this.lado=lado;
			
		}
		
		public void Leer(){
			Console.WriteLine("datos cuadrados ");
			base.Leer();// lee el color esa linea pide el color del cuadrado
			Console.Write("Ingrese tamaño cm: ");
			lado = int.Parse(Console.ReadLine());

			
		}
		public void Mostrar(){
			//return lado;
			base.Mostrar();
			Console.WriteLine("lado:   "+lado);
		}
		
		//hallar area
		
		public int area(){
			return lado*lado;
		}
		
		public void perimetro(){
			Console.WriteLine("perimetro del cuadrado"+4*lado);
		}
	}
}
