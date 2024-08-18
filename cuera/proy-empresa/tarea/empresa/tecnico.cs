/*
 * Created by SharpDevelop.
 * User: jota
 * Date: 13/04/2024
 * Time: 1:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace empresa
{
	/// <summary>
	/// Description of operario.
	/// </summary>
	public class tecnico:operario
	{
		
		
		protected string especialidad;
		
		protected tecnico():base()
		{
		
			especialidad="tec_comercial";
		}
		
			protected void Leer(){
			base.Leer();
			Console.Write("Ingrese especialidad  : ");
			especialidad=Console.ReadLine();
		}
		protected void Mostrar(){			
			base.Mostrar();
			Console.WriteLine("especialidad= "+especialidad);
		}
		

		
		public string getespecialidad(){
		return especialidad;
	}
	public void setespecialidad(string especialidad){
		this.especialidad=especialidad;// esta ingresando como parametro de entrada
		// puntero this direcciona a los atributos de la clase 
	}
	

		
		
	}
}

