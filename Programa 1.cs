using System;
					
public class Programa1
{
	public static void Main()
	{
		/*Crear un programa que pida números positivos al usuario, y vaya calculando
        la suma de todos ellos (terminará cuando se teclea un número negativo o cero).*/
		Console.WriteLine("Introduzca un número (introduce 0 o un numero negativo para cerrar)");
		int x;
		string z;
		int y=0;
		do{
			z=Console.ReadLine();
			x=int.Parse(z);
			y=y+x;
		}while(x>0);
		Console.WriteLine(y);
	}
}