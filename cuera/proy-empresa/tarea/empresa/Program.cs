/*
 * Created by SharpDevelop.
 * User: jota
 * Date: 13/04/2024
 * Time: 1:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace empresa
{
	class Program
	{
		public static void Main(string[] args)
		{
				
			
			//a) realizar el codigo con todas sus clases con los metodos set y get
			
		    directivo D=new directivo();
		//	D.Mostrar();
			oficial O=new oficial();
		//	O.Mostrar();			
			tec_comer Tc=new tec_comer();
		//	Tc.Mostrar();			
			tec_piso Tp =new tec_piso();
		//	Tp.Mostrar();	
			
			//b)verificar si los tecnicos y el oficial tienen el mismo turno
			O.turnoigual(Tc,Tp);

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}