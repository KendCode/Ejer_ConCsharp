/*
 * Creado por SharpDevelop.
 * Usuario: Strix
 * Fecha: 12/03/2024
 * Hora: 20:40
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
// este es el main
namespace figgeo
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			cuadrado c1= new cuadrado();
			//c1.Mostrar();
			//c1.Leer();
			//c1.Mostrar();
			//c1.area();
			//c1.perimetro();
			//vamos a sobrecargar contructores
			//cuadrado c2= new cuadrado("rojo",3);
			//c2.Mostrar();
			
			//cuadrado c3= new cuadrado("amarillo");
			//c3.Mostrar();
			
			//cuadrado c4= new cuadrado(6);
			//c4.Mostrar();
			rectangulo r1= new rectangulo();
		/*	r1.Mostrar();
			r1.Leer();
			r1.Mostrar();
			r1.area();
			r1.perimetro();*/
			rectangulo r2 = new rectangulo("rojo");				r2.Mostrar();
			rectangulo r3 = new rectangulo(5);					r3.Mostrar();
			rectangulo r4= new rectangulo("cafe",5);			r4.Mostrar();
			rectangulo r5= new rectangulo(8,"lila");			r5.Mostrar();
			rectangulo r6 = new rectangulo(5,2);				r6.Mostrar();
			rectangulo r7 = new rectangulo("azul",4,7);			r7.Mostrar();
			rectangulo r8 = new rectangulo(8,"verde",9);		r8.Mostrar();
			rectangulo r9 = new rectangulo(9,2,"negro");		r9.Mostrar();
			
			/*rectangulo R2=new rectangulo("rojo");
            rectangulo R3=new rectangulo(5);*/
            
		//	triangulo t1= new triangulo();
		//	t1.Mostrar();
		//	t1.Leer();
		//	t1.Mostrar();
			
			Console.ReadKey();
			
		}
	}
}