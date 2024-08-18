/*
 * Created by SharpDevelop.
 * User: LAB_3-PC
 * Date: 12/03/2024
 * Time: 20:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace proy_figGeo
{
	/// <summary>
	/// Description of Figura_Geometrica.
	/// </summary>
	/// 
	
	
	//SUS ATYRIBUTODS Y METODOS DON DE VICIBILIDA PROTEGIDA
	public class Figura_Geometrica
	{
		//declarar atributos sus tipos, propiedades
		protected String color;
		
		public Figura_Geometrica(){//un constructor con 0 parametros   constructor, inicializar variables SON PUBLICAAS
			
			color="verde";
		}
		
		public Figura_Geometrica(string color){// un constructor con un parametro para la sobrecarga    SON PUBLICAS
			this.color =color; //this es el puntero que direcciona a los atributos de la clase
			
			
		}
		protected void Leer()
		{  
			Console.Write("Ingrese el color: ");
			color = (Console.In.ReadLine());
			
		}
		protected void Mostrar(){
			Console.WriteLine("el color es = "+color);
			
		}
		//realizar 2 metodos
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
	}
}
