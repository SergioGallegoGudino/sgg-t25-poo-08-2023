using System;
using System.Text;

public class Electrodomestico{

    const double precioDefault = 100;
    const String colorDefault = "blanco";
    const String consumoDefault = "F";
    const double pesoDefault = 5;

    double precioBase;
    String color;
    String consumoEnergetico;
    double peso;

    public Electrodomestico()
    { 
        this.precioBase = precioDefault;
        this.color = colorDefault;
        this.consumoEnergetico = consumoDefault;
        this.peso = pesoDefault;
        Console.WriteLine("Por defecto");
    }
    public Electrodomestico(double precioBase, double peso)
    {
        this.precioBase = precioBase;
        this.color = colorDefault;
        this.consumoEnergetico = consumoDefault;
        this.peso = peso;
        Console.WriteLine("Parcialmente defecto");
    }
    public Electrodomestico(double precioBase, String color, String consumoEnergetico, double peso)
    {
        this.precioBase = precioBase;
        this.color = color;
        this.consumoEnergetico = consumoEnergetico;
        this.peso = peso;
        Console.WriteLine("Sin defecto");
    }
    static void Main(string[] args)
    {
        Electrodomestico e1 = new Electrodomestico();
        Electrodomestico e2 = new Electrodomestico(12.8, 20.6);
        Electrodomestico e3 = new Electrodomestico(10.0, "negro", "A", 9.7);
    }
}