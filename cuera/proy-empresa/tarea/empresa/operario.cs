/*
 * Created by SharpDevelop.
 * User: jota
 * Date: 13/04/2024
 * Time: 1:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace empresa
{
	/// <summary>
	/// Description of operario.
	/// </summary>
	public class operario:empleado
	{
		
		protected int anos_servicio;
		protected string turno;
		
		protected operario()
		{
			anos_servicio=4;
			turno="noche";
		}
		
			protected void Leer(){
			Console.Write("\nIngrese años de servicio: ");
			base.Leer();
			anos_servicio=int.Parse(Console.ReadLine());
			Console.Write("Ingrese turno: ");
			turno=Console.ReadLine();
		}
		protected void Mostrar(){
			base.Mostrar();
			Console.WriteLine("a;os de servicio= "+anos_servicio);
			Console.WriteLine("turno= "+turno);
		}
		
		
		  	public int getanos_serv(){
		return anos_servicio;
	}
	public void setanosserv(int anos_servicio){
		this.anos_servicio=anos_servicio;// esta ingresando como parametro de entrada
		// puntero this direcciona a los atributos de la clase 
	}

		
		public string getturno(){
		return turno;
	}
	public void setturno(string turno){
		this.turno=turno;// esta ingresando como parametro de entrada
		// puntero this direcciona a los atributos de la clase 
	}
		
		
		
	}
}
