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
	/// Description of Director.
	/// </summary>
	public class Director:Administrativo
	{
		protected string grado_acad;// atributo
		
		public Director():base(){//constructor
			grado_acad="magister";
		}
		public void Leer(){
			Console.WriteLine("\n** Datos de Director **");
			base.Leer();
			Console.Write("Ingrese grado académico: ");
			grado_acad=Console.ReadLine();
		}
		public void Mostrar(){
			Console.WriteLine("\n** Mostrando datos del Director **");
			base.Mostrar();
			Console.WriteLine("Grado académico= "+grado_acad);
		}
		
		
			public string getgrado_acad_dir(){
		return grado_acad;
	}
	public void setgrado_acad_dir(){
		this.grado_acad=grado_acad;// esta ingresando como parametro de entrada
		// puntero this direcciona a los atributos de la clase 
	}
		
		// como podemos ver no hay sueldo ya que pertenece a empleado por tanto se emplea los metodos get y set
		public void sueldomayor(Profesor x){
			if(sueldo==x.getsueldo())
				Console.WriteLine("\nEl director y el profe tiene el mismo sueldo");
			else if(getsueldo()>x.getsueldo())
				Console.WriteLine(" el dire tiene sueldo mayor");
			else
				Console.WriteLine("el profe tiene mayor sueldo");
		
		}
		
		
		
		// com paracion de turnos noche entre todos los administrativos
		//toLower convierte caracteres a minusculas
		//toUpper convierte los caracteres a mayusculas
		//equals es u n operador de comparacion noche ==noche??
		//noche.-equals
	/*	public void TurnoNoche(Secretaria x, Portero y)
{
			if (turno.ToLower().Equals("noche") &&  x.getturno().ToLower().Equals("noche") && y.getturno().ToLower().Equals("noche"))
    {
        Console.WriteLine("todos Tienen el turno de noche");
    }
    else if ( x.getturno().ToLower().Equals("noche") && y.getturno().ToLower().Equals("noche"))
    {
        Console.WriteLine("Portero y secretaria tienen turno");
    }
    else if (turno.ToLower().Equals("noche") && y.getturno().ToLower().Equals("noche"))
    {
        Console.WriteLine("Director y secretaria tienen turno");
    }
    else if (turno.ToLower().Equals("noche") )
    {
        Console.WriteLine("Director tiene turno");
    }
    else if ( y.getturno().ToLower().Equals("noche"))
    {
        Console.WriteLine("Portero tiene turno");
    }
    else if (x.getturno().ToLower().Equals("noche") )
    {
        Console.WriteLine("secre tiene turno");
    }
    else
    {
        Console.WriteLine("ninguno tiene turno");
    }
		}*/
		

		
		
		
	}
}
