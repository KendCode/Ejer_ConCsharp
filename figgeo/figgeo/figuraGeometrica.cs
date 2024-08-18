/*
 * Creado por SharpDevelop.
 * Usuario: Strix
 * Fecha: 12/03/2024
 * Hora: 20:42
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace figgeo
{
	/// <summary>
	/// Description of figuraGeometrica.
	/// </summary>
	public class figuraGeometrica
	{
		protected string color;
		public figuraGeometrica()
		{
			color="verde";
		}
		public figuraGeometrica (string color){
			this.color=color;//this es un puntero del parametro,direcciona alos atri8bustos que tenga la clase
		}
		
		public void Leer(){
		
			Console.Write("introduce color:    ");
			color = Console.ReadLine();
			
		}
		
	    public void Mostrar(){
		
			Console.WriteLine("color"+color);
			
		}
	}
}
