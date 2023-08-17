using System;

namespace Ejercicio3
{
    class Program
    {
        class Operaciones
        {
            int num1;
            int num2;
            public Operaciones(int num1, int num2)
            {
                this.num1 = num1;
                this.num2= num2;
            }

            public void getAll()
            {
                Console.WriteLine("Numero 1: " + num1 + " Numero 2: " + num2);
            }

            public void sumar()
            {
                Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1+num2));
            }

            public void restar()
            {
                Console.WriteLine("{0} - {1} = {2}", num1, num2, (num1 - num2));
            }

            public void multiplicar()
            {
                Console.WriteLine("{0} * {1} = {2}", num1, num2, (num1 * num2));
            }
            public void dividir()
            {
                Console.WriteLine("{0} / {1} = {2}", num1, num2, (num1 / num2));
            }

        }
        static void Main(string[] args)
        {

            Operaciones o = new Operaciones(5,5);
            o.getAll();
            o.sumar();
            o.restar();
            o.multiplicar();
            o.dividir();
            
        }
    }
}