/*
 * Creado por SharpDevelop.
 * Usuario: Hilda
 * Fecha: 26/3/2024
 * Hora: 07:46
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proy_Colegio
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona
	{
		protected string nombre;
		protected string apellidos;
		protected short edad;
		protected int ci;
		protected int cel;
		public Persona(){
			nombre="Juan";
			apellidos="rocha";
			edad=28;
			ci=123456;
			cel=7777777;
		}
		protected void Leer(){
			Console.Write("Ingrese nombre: ");
			nombre=Console.ReadLine();
			Console.Write("Ingrese apellidos: ");
			apellidos=Console.ReadLine();
			Console.Write("Ingrese edad: ");
			edad=short.Parse(Console.ReadLine());
			Console.Write("Ingrese ci: ");
			ci=int.Parse(Console.ReadLine());
			Console.Write("Ingrese celular: ");
			cel=int.Parse(Console.ReadLine());
		}
		protected void Mostrar(){
			Console.WriteLine("Nombre= "+nombre);
			Console.WriteLine("Apellidos= "+apellidos);
			Console.WriteLine("Edad= "+edad);
			Console.WriteLine("C.I.= "+ci);
			Console.WriteLine("Nro Celular= "+cel);
		}
		
		
		public string getnombre(){
		return nombre;
	}
	public void setnombre(){
		this.nombre=nombre;// esta ingresando como parametro de entrada
		// puntero this direcciona a los atributos de la clase 
	}
		
		
    	public string getapellido(){
		return apellidos;
	}
	public void setapellido(){
		this.apellidos=apellidos;// esta ingresando como parametro de entrada
		// puntero this direcciona a los atributos de la clase 
	}
		
		public short getedad(){
		return edad;
	}
	public void setedad(){
		this.edad=edad;// esta ingresando como parametro de entrada
		// puntero this direcciona a los atributos de la clase 
	}
		
		public int getcel(){
		return cel;
	}
	public void setcel(int cel){
		this.cel=cel;// esta ingresando como parametro de entrada
		// puntero this direcciona a los atributos de la clase 
	}
		
		public int getci(){
		return ci;
	}
	public void setci(){
		this.ci=ci;// esta ingresando como parametro de entrada
		// puntero this direcciona a los atributos de la clase 
	}
	}
}
