using System;

namespace ColegioHerencia
{
	public class Director: Plantel_Administrativo
	{
		
		protected string grado_estudio;
		public Director():base()
		{
			
			grado_estudio = "Licenciatura";
		}
		public void leer(){
			Console.WriteLine("Ingrese los datos del director: ");
			base.leer();
			
			Console.Write("grado de estudio: ");
			grado_estudio = Console.ReadLine();
		}
		public void mostrar(){
			Console.WriteLine();
			Console.WriteLine("--Mostrando Datos del Director--");
			base.mostrar();
			
			Console.WriteLine("Grado de estudio: "+grado_estudio);
	}
		
}
}