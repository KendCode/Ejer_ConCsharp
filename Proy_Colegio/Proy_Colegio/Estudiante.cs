/*
 * Creado por SharpDevelop.
 * Usuario: Hilda
 * Fecha: 26/3/2024
 * Hora: 07:47
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proy_Colegio
{
	/// <summary>
	/// Description of Estudiante.
	/// </summary>
	public class Estudiante:Persona
	{
		protected long rude;
		protected short grado;
		protected string nivel;
		public Estudiante():base(){
			rude=123456789;
			grado=6;
			nivel="secundaria";
		}
		public void Leer(){
			Console.WriteLine("\n** Datos de Estudiante **");
			base.Leer();
			Console.Write("Ingrese rude: ");
			rude=long.Parse(Console.ReadLine());
			Console.Write("Ingrese grado: ");
			grado=short.Parse(Console.ReadLine());
			Console.Write("Ingrese nivel: ");
			nivel=Console.ReadLine();
		}
		public void Mostrar(){
			Console.WriteLine("\n** Mostrando datos de Estudiante **");
			base.Mostrar();
			Console.WriteLine("RUDE= "+rude);
			Console.WriteLine("Grado= "+grado);
			Console.WriteLine("Nivel= "+nivel);
		}
		
			public long getrude(){
		return rude;
	}
	public void setrude(){
		this.rude=rude;// esta ingresando como parametro de entrada
		// puntero this direcciona a los atributos de la clase 
	}
		
		public short getgrado(){
		return grado;
	}
	public void setgrado(short grado){
		this.grado=grado;// esta ingresando como parametro de entrada
		// puntero this direcciona a los atributos de la clase 
	}
		
		public string getnivel(){
		return nivel;
	}
	public void setnivel(){
		this.nivel=nivel;// esta ingresando como parametro de entrada
		// puntero this direcciona a los atributos de la clase 
	}
		
		//a)
		public void buscar_rude(){
		
			Console.Write("ingrese nro rude");
				long x =long.Parse(Console.ReadLine());
			if(rude==x)
				Console.WriteLine("el estudiante es :"+nombre+""+apellidos);
			else
				Console.WriteLine("no");
			
		}
		
		
		
		
		public void modificagrado(){
		
			Console.Write("ingrese ci de estudiante");
			int x= int.Parse(Console.ReadLine());
			if(ci==x){
			
				Console.Write("ingrese nuevo grado a modificar");
				short g =short.Parse(Console.ReadLine());//entra el adto a modificar
				
				grado=g;// lo cambia
				setgrado(g);//grado=g
				
				Mostrar();

			
			}
			
			else
					Console.WriteLine("no se encontro al est");
		}
	}
}
