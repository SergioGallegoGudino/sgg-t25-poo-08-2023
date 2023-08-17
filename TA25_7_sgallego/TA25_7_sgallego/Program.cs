using System;

public class Persona
{
    String nombre;
    int edad;
    String dni;
    String sexo;
    double peso;
    double altura;

    public Persona(String dni)
    {
        this.nombre = "";
        this.edad = 0;
        this.dni = dni;
        this.sexo = "Hombre";
        this.peso = 0;
        this.altura = 0;
        Console.WriteLine("Todo por defecto");
    }
    public Persona(String nombre, int edad, String dni, String sexo)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.dni = dni;
        this.sexo = nombre;
        this.peso = 0;
        this.altura = 0;
        Console.WriteLine("Parcialmente por defecto");
    }
    public Persona(String nombre, int edad, String dni, double peso, double altura, String sexo)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.dni = dni;
        this.sexo = nombre;
        this.peso = peso;
        this.altura = altura;
        Console.WriteLine("Sin defecto");
    }


    static void Main(string[] args)
    {
        Persona p1 = new Persona("123456789W");
        Persona p2 = new Persona("Sergio", 23, "123456789W", "Hombre");
        Persona p3 = new Persona("Sergio", 23, "123456789W", 120, 1.92, "Hombre" );
    }
}
