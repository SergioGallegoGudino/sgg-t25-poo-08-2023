using System;

public class Coche
{
    String marca;
    String modelo;
    int cilindrada;
    int potencia;
    
    public Coche(String marca, String modelo, int cilindrada, int potencia) {
        this.marca = marca;
        this.modelo = modelo;
        this.cilindrada = cilindrada;
        this.potencia = potencia;
        Console.WriteLine("Marca: " + this.marca + " Modelo: " + this.modelo + " Cilindrada: " + this.cilindrada + " Potencia: " + this.potencia);
    }

    
    static void Main(string[] args)
    {
        Coche c1 = new Coche("Nissan", "Micra Sport", 23, 56);
    }
}
