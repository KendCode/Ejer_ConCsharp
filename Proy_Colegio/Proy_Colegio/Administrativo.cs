/*
 * Creado por SharpDevelop.
 * Usuario: Hilda
 * Fecha: 26/3/2024
 * Hora: 07:47
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proy_Colegio
{
	/// <summary>
	/// Description of Administrativo.
	/// </summary>
	public class Administrativo:Empleado
	{
		protected string tipo;//atributo
		
		public Administrativo():base(){//constructor
			tipo="interino"; //sale en el form
		}
		protected void Leer(){
			base.Leer();
			Console.Write("Ingrese tipo: ");
			tipo=Console.ReadLine();
		}
		protected void Mostrar(){
			base.Mostrar();
			Console.WriteLine("Tipo= "+tipo);
		}
		
			public string gettipoadm(){
		return tipo;
	}
	public void settipoadm(){
		this.tipo=tipo;// esta ingresando como parametro de entrada
		// puntero this direcciona a los atributos de la clase 
	}
		
		//segunda forma j)
		public void cambiarturn2(string x, string y){
		
			if(x.ToLower().Equals(nombre.ToLower())&& y.ToLower().Equals(apellidos.ToLower())){
				Console.Write("ingrese nuevo turno");
				turno=Console.ReadLine();
				Mostrar();
			
			}else
				Console.Write("\n los datos no coinsiden");
		}
	}
}
