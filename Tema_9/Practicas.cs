using System;
					
public class Persona
{
  public int edad;
  public string nombre;
  public string telefono;	
}

public class Cliente : Persona{
  public string credito;
}

public class Trabajador : Persona{
  public string salario;
}

public class Principal{
  public static void Main()
	{
	Cliente cliente= new Cliente();
	cliente.credito = "123456";
    cliente.edad = 20;
    cliente.nombre = "Miguel Ramos";
    cliente.telefono = "4443214569";
    

	Console.WriteLine("Nombre: {0}",cliente.nombre);
    Console.WriteLine("Edad: {0}",cliente.edad);
    Console.WriteLine("Telefono: {0}",cliente.telefono);
    Console.WriteLine("Credito: {0}", cliente.credito);
	Console.WriteLine("-----------------------");
	  
	Trabajador trabajador= new Trabajador();
	trabajador.salario = "10000";
    trabajador.edad = 24;
    trabajador.nombre = "Juan Cortina";
    trabajador.telefono = "3216549873";
	  
	  Console.WriteLine("Nombre: {0}",trabajador.nombre);
    Console.WriteLine("Edad: {0}",trabajador.edad);
    Console.WriteLine("Telefono: {0}",trabajador.telefono);
    Console.WriteLine("Credito: {0}", trabajador.salario);
	}
}