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
	/// Description of Empleado.
	/// </summary>
	public class Empleado:Persona
	{
		protected double sueldo;// atributos
		protected string turno;
		public Empleado():base(){//constructor
			sueldo=3500.80;
			turno="mañana";
		}
		protected void Leer(){
			base.Leer();
			Console.Write("Ingrese sueldo: ");
			sueldo=double.Parse(Console.ReadLine());
			Console.Write("Ingrese turno: ");
			turno=Console.ReadLine();
		}
		protected void Mostrar(){
			base.Mostrar();
			Console.WriteLine("Sueldo= "+sueldo+" Bs.");
			Console.WriteLine("Turno= "+turno);
		}
		// metodos get y set, en caso de protegido
		// el metodo get retorna el valor del atributo
	// el metodo set actualiza o cambia o modifica el valor del atributo
	public double getsueldo(){
		return sueldo;
	}
	public void setsueldo(double sueldo){
		this.sueldo=sueldo;// esta ingresando como parametro de entrada
		// puntero this direcciona a los atributos de la clase 
	}
	
	
	
	public string getturno(){
		return turno;
	}
	public void setturno(string turno){
		this.turno=turno;// esta ingresando como parametro de entrada
		// puntero this direcciona a los atributos de la clase 
	}
	
	
	
	
	//**********************************usando el segundo metodo o forma
	// como no accedemos al profe i dire, se hace uhno general y despues
	public void cambiarsueldoycelsegundaforma(string x){//para el turno
		if(turno.ToLower().Equals(x.ToLower())){
			Console.Write("ingrese nuevo sueldo");
			sueldo=double.Parse(Console.ReadLine());
			
			Console.Write("ingrese nuevo celu");
			sueldo=int.Parse(Console.ReadLine());
			Mostrar();
		}else
			Console.WriteLine("no coinside el turno");
	
	}
	}
}
