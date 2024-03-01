using System;

class Program
{
    static void Main(string[] args)
    {
        int numero;
        Console.WriteLine("Escriba un número entero: ");
        numero = int.Parse(Console.ReadLine());

        Console.WriteLine("Tabla de multiplicar del {0} es: ", numero);
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("{0} x {1} = {2}", numero, i, numero * i);
        }
    }
}
