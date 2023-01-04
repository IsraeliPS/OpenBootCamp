using System;

public class coche
{
	int puertas=3;
	
	public int numeroPuertas (int a){
		return (puertas + a);
	}
	
	public static void Main()
	{
		coche miCoche=new coche();
		int valor=miCoche.numeroPuertas(2);
		Console.WriteLine("El numero de puertas es: {0}", valor);
	}
}