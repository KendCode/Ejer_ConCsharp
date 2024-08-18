using System;

namespace ColegioHerencia
{
	public class Portero: Plantel_Administrativo
	{
		protected string area_limpieza;
		public Portero():base()
		{
			area_limpieza = "baño";
			
		}
		
		public void leer(){
			Console.WriteLine("Ingrese los datos del portero: ");
			base.leer();
			Console.Write("area_limpieza: ");
			area_limpieza = Console.ReadLine();
		}
		
		public void mostrar(){
			Console.WriteLine();
			Console.WriteLine("--Mostrando Datos deL portero--");
			base.mostrar();
			Console.WriteLine("area_limpieza: "+area_limpieza);
			
		}
	}
}
