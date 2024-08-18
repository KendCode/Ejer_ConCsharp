using System;

namespace ColegioHerencia
{
	public class Plantel_Administrativo: Persona
	{
		
		protected string tipo;
		
		public Plantel_Administrativo():base()
		{
		
			tipo = "secre";
		
			
		}
		
		protected void leer(){
			Console.WriteLine("Ingrese los datos del plantel administrativo: ");
			base.leer();
			
			Console.Write("tipo: ");
			tipo = Console.ReadLine();
			
		}
		protected void mostrar(){
			Console.WriteLine();
			Console.WriteLine("--Mostrando Datos del Plantel Administrativo--");
			base.mostrar();
			
			Console.WriteLine("tipo  "+tipo);
		
		}
		
		
		
	}
}
