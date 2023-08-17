using System;

public class Persona
{
	String nombre;
	public Persona(String nombre)
	{
		this.nombre = nombre;
	}

	public void setNombre(String nombre)
	{
		this.nombre = nombre;
	}

	public void saludar()
	{
        Console.WriteLine("Hola, soy " + nombre);
    }

    static void Main(string[] args)
    {

		Persona p1 = new Persona("");
		Persona p2 = new Persona("");
		p1.setNombre("Julio");
		p1.saludar();
		p2.setNombre("Maria");
		p2.saludar();

    }
}
