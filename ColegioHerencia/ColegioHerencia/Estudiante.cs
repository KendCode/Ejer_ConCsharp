using System;

namespace ColegioHerencia
{
	public class Estudiante: Persona
	{
		protected char grado;
		protected char paralelo;
		protected string turno;
		protected long rude;
		public Estudiante():base()
		{
			grado = '5';
			paralelo = 'A';
			turno = "Mañana";
			rude = 97767435345;
		}
		protected void leer(){
			Console.WriteLine("Ingrese los datos del estudiante: ");
			base.leer();
			Console.Write("grado: ");
			grado = char.Parse(Console.ReadLine());
			Console.Write("paralelo: ");
			paralelo = char.Parse(Console.ReadLine());
			Console.Write("Turno: ");
			turno = Console.ReadLine();
			Console.Write("Rude: ");
			rude = long.Parse(Console.ReadLine());
		}
		protected void mostrar(){
			Console.WriteLine();
			Console.WriteLine("--Mostrando Datos del Estudiante--");
			base.mostrar();
			Console.WriteLine("Grado:  "+grado);
			Console.WriteLine("Paralelo: "+paralelo);
			Console.WriteLine("Tuno:  "+turno);
			Console.WriteLine("Rude "+rude);
		}
		//a)Buscar al estudiante con CI x y mostrar su grado
		protected void buscarCI(){
			Console.Write("Intro CI del estudiante a buscar: ");
			int x = int.Parse(Console.ReadLine());
			if(x==CI){
				Console.WriteLine("El grado del estudiante es: "+grado);	
			}
			else{
					Console.WriteLine("No se encontró al estudiante");
				}
		}
		
	}
}
