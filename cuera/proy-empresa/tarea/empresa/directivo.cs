/*
 * Created by SharpDevelop.
 * User: jota
 * Date: 13/04/2024
 * Time: 1:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace empresa
{
	/// <summary>
	/// Description of operario.
	/// </summary>
	public class directivo:empleado
	{
		protected string cargo;
		protected int nro_oficina;
		
		
		public directivo():base()
		{
			cargo="a";
			nro_oficina=4;
		}
		
			public void Leer(){
			base.Leer();
			Console.Write("Ingrese cargo: ");
			cargo=Console.ReadLine();
			Console.Write("\nIngrese numero de oficina: ");
			nro_oficina=int.Parse(Console.ReadLine());
		}
		public void Mostrar(){
			base.Mostrar();
			Console.WriteLine("cargo= "+cargo);
			Console.WriteLine("numero de oficina= "+nro_oficina);
		}
		
		
		  	public int getnro_oficina(){
		return nro_oficina;
	}
		public void setnro_oficina(int nro_oficina){
		this.nro_oficina=nro_oficina;// esta ingresando como parametro de entrada
		// puntero this direcciona a los atributos de la clase 
	}

		
		public string getcargo(){
		return cargo;
	}
	public void setcargo(string cargo){
		this.cargo=cargo;// esta ingresando como parametro de entrada
		// puntero this direcciona a los atributos de la clase 
	}
		

		
		
		
	}
}