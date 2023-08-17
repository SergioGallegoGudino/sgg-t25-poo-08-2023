using System;
using System.Text;

public class Password
{
    int longitud;
    String passwd;

    public String passwdRandom(int longitud)
    {
        String passwd = "";
        const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        StringBuilder sb = new StringBuilder(); 
        Random random  = new Random();

        for (int i = 0; i < longitud; i++)
        {
            int caracter = random.Next(chars.Length);
            sb.Append(chars[caracter]);
        }

        return sb.ToString();
    }
    public Password()
    {
        this.longitud = 8;
        this.passwd = "root";
        Console.WriteLine("Por defecto");
    }
    public Password(int longitud)
    {
        this.longitud = longitud;
        this.passwd = passwdRandom(longitud);
        Console.WriteLine(this.passwd);
    }
    static void Main(string[] args)
    {
        Password p1 = new Password();
        Password p2 = new Password(9);
    }
}