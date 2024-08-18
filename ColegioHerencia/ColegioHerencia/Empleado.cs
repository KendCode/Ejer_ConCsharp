using System;

namespace ColegioHerencia
{
	public class Empleado: Persona
	{
		
		protected string turno;
		protected double sueldo;
		public Empleado():base()
		{
			
			turno = "noche";
			sueldo=2580.5;
		}
		public void leer(){
			Console.WriteLine("Ingrese los datos de empleador: ");
			base.leer();
			Console.Write("turno: ");
			
			turno = Console.ReadLine();
			Console.Write("turno: ");
			sueldo= double.Parse(Console.ReadLine());
		}
		public void mostrar(){
			Console.WriteLine();
			Console.WriteLine("--Mostrando Datos de empleador--");
			base.mostrar();
			
			Console.WriteLine("cargo  "+turno);
			Console.WriteLine("sueldo  "+sueldo);
		}
	}
}
