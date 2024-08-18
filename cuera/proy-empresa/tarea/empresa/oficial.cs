/*
 * Created by SharpDevelop.
 * User: jota
 * Date: 13/04/2024
 * Time: 1:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace empresa
{
	/// <summary>
	/// Description of operario.
	/// </summary>
	public class oficial:operario
	{
		
		
		protected string grado;
		
		public oficial():base()
		{
		
			grado="subteniente";
		}
		
			public void Leer(){
			base.Leer();
			Console.Write("Ingrese grado  : ");
			grado=Console.ReadLine();
		}
		public void Mostrar(){	
            base.Mostrar();			
			Console.WriteLine("grado= "+grado);
		}
		

		
		public string getgrado(){
		return grado;
	}
	public void setgrado(string grado){
		this.grado=grado;// esta ingresando como parametro de entrada
		// puntero this direcciona a los atributos de la clase 
	}
		
 
	
		
	//B)	
public void turnoigual(tec_comer x, tec_piso y){
			if(turno==x.getturno()&&turno==y.getturno())
				Console.WriteLine("\nEl oficial y los tecnicos tiene el mismo turno");
			
			else
				Console.WriteLine("sus turnos no son iguales");
		
		}
		
		

		
	}
}
