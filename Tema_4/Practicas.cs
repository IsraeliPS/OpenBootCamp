using System;
					
public class Numeros
{
	public string positivoNegativo (int numeroIf){
      if (numeroIf < 0)
        return "Negativo";
        else if (numeroIf > 0)
          return "Positivo";
          else
            return "0";
	}

  public void bucleWhile (int numeroWhile){
    while (numeroWhile < 3)
      {
        Console.WriteLine("Número es: {0}", numeroWhile)
        numeroWhile ++ ;
      }
  }

  public void bucleDowhile(int numeroDowhile){
    do{
      Console.WriteLine("Número es: {0}", numeroDowhile)
      numeroDowhile ++ ;
    } while (numeroDowhile < 3)
  }

  public void bucleFor (){
    for (int i = 0;i<=3; i++){
      Console.WriteLine("Número es: {0}", i)
    }
  }

  public string condicionSwitch(int estacion){

    switch (estacion){
      case 1: return "Primavera";
      case 2: return "Verano";
      case 3: return "Otoño";
      case 4: return "Invierno";
      default: return "Solo valores de 1 - 4"
    }
  }
	
	public static void Main()
	{
		Numeros resultado= new Numeros();

    //Ejercicio 1
		Console.WriteLine("El numeros es: {0}", resultado.positivoNegativo(-5));

    //Ejercicio 2
    resultado.bucleWhile(0);

    //Ejercicio 3
    resultado.bucleDowhile(2);

    //Ejercicio 4
    resultado.bucleFor();

    //Ejercicio 5
    Console.WriteLine("Estacion: {0}",resultado.condicionSwitch(1));
	}
}