/*
 * Created by SharpDevelop.
 * User: jota
 * Date: 13/04/2024
 * Time: 1:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace empresa
{
	/// <summary>
	/// Description of operario.
	/// </summary>
	public class tec_piso:tecnico
	{
		
		
		protected string tipo;
		
		public tec_piso():base()
		{
		
			tipo="pimer_nivel";
		}
		
			public void Leer(){
			base.Leer();
			Console.Write("Ingrese tipo  : ");
			base.Leer();
			tipo=Console.ReadLine();
		}
		public void Mostrar(){
            base.Mostrar();			
          		
			Console.WriteLine("tipo= "+tipo);
		}
		

		
		public string gettipo(){
		return tipo;
	}
	public void settipo(string tipo){
		this.tipo=tipo;// esta ingresando como parametro de entrada
		// puntero this direcciona a los atributos de la clase 
	}
		
		
		
	}
}