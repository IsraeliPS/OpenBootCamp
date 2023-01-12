using System;
					
public class Persona
{
  private int edad;
  private string nombre;
  private string telefono;
	
  public int getEdad(){
    return this.edad;
  }
  public string getNombre(){
    return this.nombre;
  }
  public string getTelefono(){
    return this.telefono;
  }

  public void setEdad(int edad){
    this.edad = edad;
  }

  public void setNombre(string nombre){
    this.nombre = nombre;
  }

  public void setTelefono(string telefono){
    this.telefono = telefono;
  }
}

public class Main{
  public static void Main()
	{
		Persona persona= new Persona();
    persona.setTelefono("Miguel Ramos");
    persona.setEdad(20);
		persona.setTelefono("5576720173");

		Console.WriteLine("Nombre: {0}",persona.getNombre());
    Console.WriteLine("Edad: {0}",persona.getEdad());
    Console.WriteLine("Telefono: {0}",persona.getTelefono());
	}
}