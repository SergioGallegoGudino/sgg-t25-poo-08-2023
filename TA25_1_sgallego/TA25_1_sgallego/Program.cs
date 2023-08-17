using System;

namespace Ejercicio1
{
    class Program
    {
        class Alumno
        {
            String nombre;
            int edad;
            public Alumno(string nombre, int edad)
            {
                this.nombre = nombre;
                this.edad = edad;
            }

            public void getAll()
            {
                Console.WriteLine("Nombre: " + nombre + " Edad: " + edad);
            }

            public void esMayor()
            {
                if (edad >= 18)
                {
                    Console.WriteLine("Es mayor de edad.");
                }
                else
                {
                    Console.WriteLine("Es menor de edad.");
                }
            }
        }
        static void Main(string[] args)
        {
            Alumno a = new Alumno("Sergio", 21);
            a.getAll();
            a.esMayor();
        }
    }
}