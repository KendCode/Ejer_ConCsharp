/*
 * Creado por SharpDevelop.
 * Usuario: Hilda
 * Fecha: 26/3/2024
 * Hora: 07:48
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proy_Colegio
{
	/// <summary>
	/// Description of Portero.
	/// </summary>
	public class Portero:Administrativo
	{
		protected string area_lim;// atributo
		
		public Portero():base(){//constructor
			area_lim="Bloque B";
		}
		public void Leer(){
			Console.WriteLine("\n** Datos de Portero **");
			base.Leer();
			Console.Write("Ingrese área de limpieza: ");
			area_lim=Console.ReadLine();
		}
		public void Mostrar(){
			Console.WriteLine("\n** Mostrando datos del Portero **");
			base.Mostrar();
			Console.WriteLine("Área de limpieza= "+area_lim);
		}
		
		
		
			public string getarealimp(){
		return area_lim;
	}
	public void setarealim(){
		this.area_lim= area_lim;// esta ingresando como parametro de entrada
		// puntero this direcciona a los atributos de la clase 
	}
		
		public void comparaarealimpieza(Portero x){
			if(area_lim.ToLower().Equals(x.area_lim.ToLower()))
				Console.WriteLine("\t trabajan en la misma area de limpieza"+area_lim);
			else
				Console.WriteLine("\t no trabajan en la misma area de limpieza");
		}
	}
}
