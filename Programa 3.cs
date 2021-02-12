using System;
					
public class Programa3
{
	public static void Main()
	{
		/* Crear un programa que muestre los primeros 10 números pares a partir del producto de (10 x 10)*/
		int x =100;
		int contador=0;
		do{
			x=x+1;
			if(x%2==0){
				contador++;
				Console.WriteLine(x);
			}
		}while(contador<10);
	}
}