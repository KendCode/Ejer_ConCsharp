/*
 * Creado por SharpDevelop.
 * Usuario: Hilda
 * Fecha: 26/3/2024
 * Hora: 07:45
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proy_Colegio
{
	class Program
	{
		public static void Main(string[] args)
		{
			Director D=new Director();
			D.Mostrar();
			Secretaria S=new Secretaria();
			S.Mostrar();			
			Profesor P=new Profesor();
			P.Mostrar();			
			Estudiante E =new Estudiante();
			E.Mostrar();			
			Portero Po=new Portero();
			Po.Mostrar();
			
			
			//a) buscar al estudiante por rude x y mostrar su noimbre y apellido el metodo esta en la clkkase estudiante  a)
			//E.buscar_rude();
			//b)buscar  la Secretaria Portero ConsoleSpecialKey yield mostrar nombre yield sueldo
			//S.Buscarci();
			//
			//c) hallar al prefdesor cub suitem  z sealed encuentra mostrarsu turno
			//P.buscaritem();
			
			//d) entre el profesor y el director quien tiene mas sueldo?
			//D.sueldomayor(P);//ojo como el metodo usa dos clases es necesario colocar la clase con la que se usa el prog esta en director y lo compara con profesor
			
	//		D.TurnoNoche(S,Po);
			// de los administrativo quien o quienes trabajan turno noche???
			
			//f)buscar al Estudiante cix yield modificar sugrado
		//	E.modificagrado();
			//g) entre secretaria y portero quien trabaja en turno x
			
		//	S.modificarturno(Po);
			
			//h) actualizar el sueldo de director y profesor mas un 15 %  de su sueldo actual
			
	//		P.modificasueldoprofanddire(D);
			
			
			// entre el profesor y el director buscar quien trabaja en turno x y modificar modificar sueldo y celular
			
			//************************* primera forma sinla utilizacion de metodos *****************
			
		//	P.cambiartunoycel(D);
			//************************* segunda forma sinla utilizacion de metodos det y get usando clases bases y estas heredan*****************
			// ir a donde esta el atrtibuto y ahi realizar un metodo para luego comparar y con eso lo modifica y al fianl muestra dtodos los datos se usa en las clases que se pueda si llamamos al metodo donde esta el atrib
		//	P.cambiosueldycel2p(D);
			
			//j)entre los adminitrativos buscar por nombre"x" y apellido"y" cambiar el turno por "z"
			
			//1ra forma
		//	S.cambiarturn1raforma(D,Po);
		// segunda forma
//		S.cambiaoturn2forma(Po,D);
		
		//   k) comparar si los dos porteros trabajan en nla misma area de limpieza
		Portero Po2=new Portero();
		Po2.Mostrar();
		Po2.Leer();
		Po.comparaarealimpieza(Po2);
		
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
			
		}
	}
}