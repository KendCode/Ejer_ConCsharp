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
	/// Description of Secretaria.
	/// </summary>
	public class Secretaria:Administrativo
	{
		protected string grado_acad;
		public Secretaria():base(){
			grado_acad="Tec.Sup.";
			turno= "mañana";
			nombre="raquel";
		}
		public void Leer(){
			Console.WriteLine("\n** Datos de Secretaria **");
			base.Leer();
			Console.Write("Ingrese grado académico: ");
			grado_acad=Console.ReadLine();
		}
		public void Mostrar(){
			Console.WriteLine("\n** Mostrando datos de Secretaria **");
			base.Mostrar();
			Console.WriteLine("Grado académico= "+grado_acad);
		}
		
		public void Buscarci(){
	
			Console.Write("ingrese ci de secre:");
			int x = int.Parse(Console.ReadLine());
			if(ci==x){
				Console.WriteLine("su nombre ese es: "+nombre+"un sueldo de::"+sueldo+"BS");	
			}
			else{
					Console.WriteLine("No se encontró al estudiante");
				}
	}
		
		//g)
		public void modificarturno(Portero p){
		
		
			Console.WriteLine("ingrese turno a buscar");
			string x=Console.ReadLine();
			if(getturno().ToUpper().Equals(x.ToUpper())){
			   Console.Write("ingrese nuevo turno de la sec re");
			   string y= Console.ReadLine();
			   setturno(y);
			   Mostrar();
			
			}
			
			if(p.getturno().ToUpper().Equals(x.ToUpper())){
			   Console.Write("ingrese nuevo turno del portero");
			   //string y= Console.ReadLine();
			   p.setturno(Console.ReadLine());
			   p.Mostrar();
			
			}
			
				
		
		
		}
		
		
		//i)por primera forma
		public void cambiarturn1raforma(Director d, Portero p){
			
			Console.Write("ingrese nombre delegate adminitrativo");
			string x=Console.ReadLine().ToUpper();
			
			Console.Write("ingrese apellido delegate adminitrativo");
			string y=Console.ReadLine().ToUpper();
			
			if(getnombre().ToUpper().Equals(x) && getapellido().ToUpper().Equals(y)){
				Console.Write("ingrese nuevo tuyrno de la secre");
				setturno(Console.ReadLine());
				Mostrar();
			}
		
			if(d.getnombre().ToUpper().Equals(x) && getapellido().ToUpper().Equals(y)){
				Console.Write("ingrese nuevo tuyrno del dire");
				d.setturno(Console.ReadLine());
				d.Mostrar();
			}
			
			if(p.getnombre().ToUpper().Equals(x) && getapellido().ToUpper().Equals(y)){
				Console.Write("ingrese nuevo tuyrno del portero");
				p.setturno(Console.ReadLine());
				p.Mostrar();
			}
		}
		
		
		// jota) segunda forma
		public void cambiaoturn2forma(Portero p, Director d){
			Console.Write("ingrese nombre del adminitrativo");
			string x=Console.ReadLine().ToUpper();
			
			Console.Write("ingrese apellido delegate adminitrativo");
			string y=Console.ReadLine().ToUpper();
			
			Console.WriteLine("---------secre---------");
			cambiarturn2(x,y);
		Console.WriteLine("---------portero---------");
			p.cambiarturn2(x,y);
			Console.WriteLine("---------director---------");
			d.cambiarturn2(x,y);
		}
	}
}
