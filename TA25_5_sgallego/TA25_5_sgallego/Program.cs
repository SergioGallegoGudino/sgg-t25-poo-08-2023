using System;

public class Libro
{
    String autor;
    String titulo;
    String ubicacion;
    public Libro(String autor, String titulo, String ubicacion)
    {
        this.autor = autor;
        this.titulo = titulo;
        this.ubicacion = ubicacion;
    }

    public void setAutor(String autor)
    {
        this.autor = autor;
    }
    public String getAutor() { 
        return this.autor;
    }

    public String getTitulo()
    {
        return this.titulo;
    }

    public void setTitulo(String titulo)
    {
        this.titulo = titulo;
    }
    public String getUbicacion()
    {
        return this.ubicacion;
    }

    public void setUbicacion(String ubicacion)
    {
        this.ubicacion= ubicacion;
    }

    static void Main(string[] args)
    {

        Libro l1 = new Libro("", "", "");
        l1.setTitulo("Libro antiguo");
        l1.setAutor("Desconocido");
        l1.setUbicacion("Menorca");
        Console.WriteLine("Titulo: " + l1.getTitulo() + " Autor: " + l1.getAutor() + " Ubicacion: " + l1.getUbicacion());

    }
}
