/*
 * Created by SharpDevelop.
 * User: jota
 * Date: 13/04/2024
 * Time: 1:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace empresa
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class empleado
	{
		protected string nombre;
		protected string apellidos;
		protected int ci;
		protected double sueldo;
		public empleado(){
			nombre="Juan";
			apellidos="rocha";
			ci=123456;
			sueldo=1000;
			
		}
		protected void Leer(){
			Console.Write("Ingrese nombre: ");
			nombre=Console.ReadLine();
			Console.Write("Ingrese apellidos: ");
			apellidos=Console.ReadLine();
			Console.Write("Ingrese ci: ");
			ci=int.Parse(Console.ReadLine());
			Console.Write("Ingrese celular: ");
			sueldo=double.Parse(Console.ReadLine());
		}
		protected void Mostrar(){
			Console.WriteLine("Nombre= "+nombre);
			Console.WriteLine("Apellidos= "+apellidos);
			Console.WriteLine("C.I.= "+ci);
			Console.WriteLine("sueldo= "+sueldo);
		}
		
		
		public string getnombre(){
		return nombre;
	}
	public void setnombre(string nombre){
		this.nombre=nombre;// esta ingresando como parametro de entrada
		// puntero this direcciona a los atributos de la clase 
	}
		
		
    	public string getapellido(){
		return apellidos;
	}
	public void setapellido(string apellido){
		this.apellidos=apellidos;// esta ingresando como parametro de entrada
		// puntero this direcciona a los atributos de la clase 
	}
		
		
		public double getsueldo(){
		return sueldo;
	}
	public void setsueldo(double sueldo){
		this.sueldo=sueldo;// esta ingresando como parametro de entrada
		// puntero this direcciona a los atributos de la clase 
	}
		
		public int getci(){
		return ci;
	}
	public void setci(int ci){
		this.ci=ci;// esta ingresando como parametro de entrada
		// puntero this direcciona a los atributos de la clase 
	}
	
		//**********************************usando el segundo metodo o forma
	// como no accedemos al profe i dire, se hace uhno general y despues
	public void mostrarempleado(int x){//para el ci
		if(ci==x){
	
			Mostrar();
		}else
			Console.WriteLine("no coinside el ci");
	
	}
	
	
	
	}
}
