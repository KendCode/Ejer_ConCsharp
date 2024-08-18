/*
 * Created by SharpDevelop.
 * User: jota
 * Date: 13/04/2024
 * Time: 1:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace empresa
{
	/// <summary>
	/// Description of operario.
	/// </summary>
	public class tec_comer:tecnico
	{
		public string area;
		protected string sucursal_trab;
		
		public tec_comer():base()
		{
			sucursal_trab="senkata";
			area="ventas";
		}
		
			public void Leer(){
			Console.Write("Ingrese area  : ");
			area=Console.ReadLine();
			
			Console.Write("Ingrese sucursal donde trabaja  : ");
			sucursal_trab=Console.ReadLine();
		}
		public void Mostrar(){
            Console.WriteLine("area= "+area);			
			Console.WriteLine("suculsal= "+sucursal_trab);
		}
		

		
		public string getarea(){
		return area;
	}
	public void setarea(string area){
		this.area=area; 
	}
	public string getsucursal(){
		return sucursal_trab;
	}
	public void setsucursal(string sucursal_trab){
		this.sucursal_trab=sucursal_trab; 
	}
		

		
	}
}
