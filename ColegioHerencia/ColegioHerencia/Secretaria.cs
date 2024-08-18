using System;

namespace ColegioHerencia
{
	
	public class Secretaria: Plantel_Administrativo
	{
	
		protected string grado_estudio;
	
		public Secretaria():base()
		{
			
			grado_estudio = "Licenciatura";
		
		}
		public void leer(){
			Console.WriteLine("Ingrese los datos de la secretaria: ");
			base.leer();
			
			Console.Write("grado de estudio: ");
			grado_estudio = Console.ReadLine();
		
		}
		public void mostrar(){
			Console.WriteLine();
			Console.WriteLine("--Mostrando Datos de la secretaria--");
			base.mostrar();
			
			Console.WriteLine("grado de estudio: "+grado_estudio);
	
	
	}
	}
}
