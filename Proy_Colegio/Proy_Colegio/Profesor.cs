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
	/// Description of Profesor.
	/// </summary>
	public class Profesor:Empleado
	{
		
		protected int item;
		protected int celular;
		protected string especialidad;
		public Profesor():base(){
			item=987654;
			celular=77777777;
			especialidad="matemática";
		}
		public void Leer(){
			Console.WriteLine("\n** Datos de Profesor **");
			base.Leer();
			Console.Write("Ingrese item: ");
			item=int.Parse(Console.ReadLine());
			Console.Write("Ingrese cel: ");
			celular=int.Parse(Console.ReadLine());
			Console.Write("Ingrese especialidad: ");
			especialidad=Console.ReadLine();
		}
		public void Mostrar(){
			Console.WriteLine("\n** Mostrando datos de Profesor **");
			base.Mostrar();
			Console.WriteLine("Item= "+item);
			Console.WriteLine("cel= "+celular);
			Console.WriteLine("Especialidad= "+especialidad);
		}
		
		
		public void buscaritem(){
		Console.Write("ingrese nro item");
				int z =int.Parse(Console.ReadLine());
			if(item==z)
				Console.WriteLine("el profe es:: :"+nombre+"_____"+"y su turno es"+turno+"______"+"celular"+celular+"_____"+"su especialidad es "+especialidad);
			else
				Console.WriteLine("no");
		
		}
		
		//h)
			public void modificasueldoprofanddire(Director d){
		
		
			sueldo=sueldo+(sueldo*0.15);
			Mostrar();
			d.setsueldo(d.getsueldo()+d.getsueldo()*0.15);
			d.Mostrar();
				
		}
		//i) **************usando la primera forma*****************************
	// el turno se busca por teclado hay que cambiar turno y sueldo
		public void cambiartunoycel(Director d){
		Console.Write("ingrese turno a buscar");
		string x=Console.ReadLine();
		if(getturno().ToLower().Equals(x.ToLower())){
			Console.Write("ingrese n uevo sueldo");
			setsueldo(double.Parse(Console.ReadLine()));
			Console.Write("ingrese nuevo numero de cel");
			setcel(int.Parse(Console.ReadLine()));
			Mostrar();
		}
		
		if(d.getturno().ToLower().Equals(x.ToLower())){
			Console.Write("ingrese n uevo sueldo pal dire");
			d.setsueldo(double.Parse(Console.ReadLine()));
			Console.Write("ingrese nuevo numero de cel");
			d.setcel(int.Parse(Console.ReadLine()));
			d.Mostrar();
		}
			}
	
	// i) segunda forma
	public void cambiosueldycel2p(Director z){//para no confundirlo con el dire d de arriba
	Console.Write("ingrese turno a buscar");
		string x=Console.ReadLine();
		Console.Write("pal profe");
		cambiarsueldoycelsegundaforma(x);// como el metodo ya esta en empleado solo lo llamamos
		Console.Write("pal dir");
		z.cambiarsueldoycelsegundaforma(x);
	}
	
	}
}
