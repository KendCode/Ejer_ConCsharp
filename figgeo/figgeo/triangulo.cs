/*
 * Creado por SharpDevelop.
 * Usuario: Strix
 * Fecha: 14/03/2024
 * Hora: 20:56
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace figgeo
{
	/// <summary>
	/// Description of triangulo.
	/// </summary>
	public class triangulo:figuraGeometrica
	{
		protected int ancho;
		protected int largo;
		protected int angulo;
		public triangulo():base()
		{
			ancho=1;
			largo=2;
			angulo=30;
			
		}

	public void Leer(){// puede ser publicos o privados
			Console.WriteLine("--datos del trianangulo");
			base.Leer();
		    Console.WriteLine("ingrese base ");
		    ancho = int.Parse(Console.ReadLine());
			Console.Write("Ingrese altura : ");
			largo = int.Parse(Console.ReadLine());	
			Console.Write("Ingrese angulo : ");
			angulo = int.Parse(Console.ReadLine());
		}
		
		public void Mostrar(){
			Console.WriteLine("mostrando datos del triangulo");
			base.Mostrar();
			Console.WriteLine("base:   "+ancho);
			Console.WriteLine("altura:   "+largo);
			Console.WriteLine("angulo:   "+angulo);
		}
		}
}
