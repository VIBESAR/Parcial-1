using System;

class Program
{
    static void Main(string[] args)
    {
        int numero;
        do
        {
            Console.WriteLine("Escriba Un Numero Entero Positivo: ");
            numero = int.Parse(Console.ReadLine());
        } while (numero <= 0);

        int opcion;
        do
        {
            Console.WriteLine("\nSeleccione una opción:");
            Console.WriteLine("1. Calcular factorial");
            Console.WriteLine("2. Calcular raíz cuadrada");
            Console.WriteLine("3. Salir del programa");
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    int factorial = 1;
                    for (int i = 1; i <= numero; i++)
                    {
                        factorial *= i;
                    }
                    Console.WriteLine("El factorial de {0} es {1}", numero, factorial);
                    break;
                case 2:
                    double raizCuadrada = Math.Sqrt(numero);
                    Console.WriteLine("La raíz cuadrada de {0} es {1}", numero, raizCuadrada);
                    break;
                case 3:
                    Console.WriteLine("Saliendo Del Programa.");
                    break;
                default:
                    Console.WriteLine("Opción Invalida. Intente de nuevo.");
                    break;
            }
        } while (opcion != 3);
    }
}
