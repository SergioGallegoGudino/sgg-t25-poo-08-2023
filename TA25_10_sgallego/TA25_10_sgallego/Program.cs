using System;
using System.Text;

public class Serie
{
    String titulo;
    int temporadas;
    Boolean entregado;
    String genero;
    String creador;

    public Serie()
    {
        this.titulo = "";
        this.temporadas = 3;
        this.entregado = false;
        this.genero = "";
        this.creador = "";
        Console.WriteLine("Por defecto");
    }
    public Serie(String titulo, String creador)
    {
        this.titulo = titulo;
        this.temporadas = 3;
        this.entregado = false;
        this.genero = "";
        this.creador = creador;
        Console.WriteLine("Parcialmente defecto");
    }
    public Serie(String titulo, int temporadas, Boolean entregado, String genero, String creador)
    {
        this.titulo = titulo;
        this.temporadas = temporadas;
        this.entregado = entregado;
        this.genero = genero;
        this.creador = creador;
        Console.WriteLine("Sin defecto");
    }
    static void Main(string[] args)
    {
        Serie s1 = new Serie();
        Serie s2 = new Serie("Steven Universe", "Rebecca Sugar");
        Serie s3 = new Serie("Adventure Time", 8, true, "Aventuras", "Pendelton Ward");
    }
}