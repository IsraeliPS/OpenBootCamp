using System;
					
public class Suma
{
	public int numeros (int a, int b, int c){
		return (a+b+c);
	}
	
	public static void Main()
	{
		Suma resultado= new Suma();
		int resultadoValores=resultado.numeros(1,2,3);
		Console.WriteLine("El resultado de la suma de numeros es: {0}", resultadoValores);
	}
}