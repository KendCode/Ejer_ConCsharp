using System;

namespace ColegioHerencia
{
	public class Persona
	{
		protected int CI;
		protected int Cel;
		protected int edad;
		protected string apellido;
		
		protected string nombres;
		
		
		public Persona()
		{
			CI = 9249190;
			Cel=73276637;
			edad=28;
			apellido = "Rodriguez";
			
			nombres ="Eduardo Alberto";
	
		
		}
		protected void leer(){
			Console.WriteLine("Ingrese los datos de la persona: ");
			Console.Write("Nro CI: ");
			CI = int.Parse(Console.ReadLine());
			
			
			Console.Write("Nro Celular: ");
			Cel = int.Parse(Console.ReadLine());
			
			Console.Write("edad: ");
			edad = int.Parse(Console.ReadLine());
			
			Console.Write("Paterno: ");
			apellido = Console.ReadLine();
		
			Console.Write("Nombres: ");
			nombres = Console.ReadLine();
			
			
			
			
		}
		protected void mostrar(){
			Console.WriteLine("Datos de la persona: ");
			Console.WriteLine();
			Console.WriteLine("Nro CI: "+CI);
			Console.WriteLine("Nro Celular: "+Cel);
			Console.WriteLine("edad: "+edad);
			Console.WriteLine("Paterno: "+apellido);
		
			Console.WriteLine("Nombres: "+nombres);
			
			
			
		}
	}
}
