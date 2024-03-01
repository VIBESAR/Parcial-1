using System;

class Program
{
    static void Main(string[] args)
    {
        int num1, num2;
        Console.WriteLine("Escriba el primer número: ");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Escriba el segundo número: ");
        num2 = int.Parse(Console.ReadLine());

        char operador;
        do
        {
            Console.WriteLine("Escriba el operador matemático (+, -, *, /): ");
            operador = Console.ReadKey().KeyChar;
        } while (!ValidarOperador(operador));

        int resultado = 0;
        switch (operador)
        {
            case '+':
                resultado = num1 + num2;
                break;
            case '-':
                resultado = num1 - num2;
                break;
            case '*':
                resultado = num1 * num2;
                break;
            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("Error: División en cero.");
                    return;
                }
                resultado = num1 / num2;
                break;
        }

        Console.WriteLine("\nEl resultado de {0} {1} {2} es {3}", num1, operador, num2, resultado);
    }

    static bool ValidarOperador(char operador)
    {
        return operador == '+' || operador == '-' || operador == '*' || operador == '/';
    }
}
