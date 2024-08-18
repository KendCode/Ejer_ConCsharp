
using System;

namespace ColegioHerencia
{
	public class Docente: Empleado
	{
		protected int item;
		protected string especialidad;
		

		public Docente():base()
		{
			item=4545454;
			especialidad = "manual";
			
			
		}
		public void leer(){
			Console.WriteLine("Ingrese los datos del docente: ");
			base.leer();
			Console.Write("item: ");
			item = int.Parse(Console.ReadLine());
			Console.Write("especialidad: ");
			especialidad = Console.ReadLine();
			
			
		}
		public void mostrar(){
			Console.WriteLine();
			Console.WriteLine("--Mostrando Datos del Docente--");
			base.mostrar();
			Console.WriteLine("Nro item: "+item);
			Console.WriteLine("especialidad:  "+especialidad);
			
			
			
		}
		
		}
	}
