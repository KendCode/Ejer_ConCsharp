/*
 * Created by SharpDevelop.
 * User: LAB_3-PC
 * Date: 12/03/2024
 * Time: 20:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace proy_figGeo
{
	class Program
	{
		public static void Main(string[] args)
			
		{
			

			
			
			/*Figura_Geometrica cuadrado = new Figura_Geometrica();
			cuadrado.Leer();
			cuadrado.color ="negro";
			cuadrado.Mostrar();
			solo se llaman a las ultimas clases heredadas*/
			
			//Cuadrado c1=new Cuadrado();
			/*c1.mostrar();
			c1.leer();
			c1.mostrar();
			c1.area();
			c1.perimetro();*/
			
			/*rectangulo r1 = new rectangulo();
			r1.mostrar();
			r1.leer();
			r1.mostrar();
			r1.area();
			r1.perimetro();
			
			triangulo t1= new triangulo();
			t1.mostrar();
			t1.leer();
			t1.mostrar();*/
			
		//MOSTRAR LA SOBRECARGA de la clase cuadrado con paramnetros
			Cuadrado c1= new Cuadrado();					
			c1.leer();
			c1.mostrar();
			Console.WriteLine("el area del cuadrado"+c1.area());
			/*Cuadrado c2= new Cuadrado("amarillo");			c2.mostrar();
			Cuadrado c3= new Cuadrado(6);					c3.mostrar();
			Cuadrado c4= new Cuadrado("rojo",8);			c4.mostrar();
			Cuadrado c5=new Cuadrado(7, "verde");			c5.mostrar();*/
			
			
			
			rectangulo r1 = new rectangulo();					
			r1.leer();
			r1.mostrar();
          	Console.WriteLine("el area del RECTANGULOO"+r1.area());
          
			/*	rectangulo r2 = new rectangulo("rojo");				r2.mostrar();
			rectangulo r3 = new rectangulo(5);					r3.mostrar();
			rectangulo r4= new rectangulo("cafe",5);			r4.mostrar();
			rectangulo r5= new rectangulo(8,"lila");			r5.mostrar();
			rectangulo r6 = new rectangulo(5,2);				r6.mostrar();
			rectangulo r7 = new rectangulo("azul",4,7);			r7.mostrar();
			rectangulo r8 = new rectangulo(8,"verde",9);		r8.mostrar();
			rectangulo r9 = new rectangulo(9,2,"negro");		r9.mostrar();*/	
			
			
			triangulo t1= new triangulo();
			t1.mostrar();
			t1.leer();
			t1.mostrar();
			Console.WriteLine("el area del TRIANGULO"+t1.area());
			
			
			
			//comparacion de datos verficar que area es mayor entr cuadrado y rectangulo*************26032024
			
		/*	if(c1.area()>r1.area())
				Console.WriteLine("el cuadrado gana");
			else
			Console.WriteLine("el rectangulo gana");*/
		//r1.mayorarea_rc(c1);
			
			//hallar area mayor entr cuadrado y recxtanguilo
				r1.mayorarea_rc(c1);
				//calcule el area mayor entre cuadrado rectangulo y triangulo
				c1.mayorarea_crt(r1,t1);
				
				//calcule el area mayor entre cuadrado rectangulo y triangulo
				t1.menorarea_crt(r1,c1);
			
			
			
			//no se añade al metodo leer y mostrar el area por que el calculo de area es distinto
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}