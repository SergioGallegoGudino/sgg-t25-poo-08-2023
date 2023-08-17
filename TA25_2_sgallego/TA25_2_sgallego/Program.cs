using System;

namespace Ejercicio1
{
    class Program
    {
        class Empleado
        {
            String nombre;
            double sueldo;
            public Empleado(string nombre, double sueldo)
            {
                this.nombre = nombre;
                this.sueldo = sueldo;
            }

            public void getAll()
            {
                Console.WriteLine("Nombre: " + nombre + " Sueldo: " + sueldo);
            }

            public void pagaImpuestos()
            {
                if (sueldo > 3000)
                {
                    Console.WriteLine("Debe pagar impuestos.");
                }
                else
                {
                    Console.WriteLine("No debe pagar impuestos.");
                }
            }
        }
        static void Main(string[] args)
        {
            Empleado e = new Empleado("Sergio", 3020);
            e.getAll();
            e.pagaImpuestos();
        }
    }
}