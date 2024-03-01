using System;

class program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);

        bool adivinado = false;
        int numeroIntroducido;

        while (!adivinado)
        {
            Console.WriteLine("Escriba un número entre 1 y 100: ");
            numeroIntroducido = int.Parse(Console.ReadLine());

            if (numeroIntroducido > numeroSecreto)
            {
                Console.WriteLine("El número secreto es menor que {0}", numeroIntroducido);
            }
            else if (numeroIntroducido < numeroSecreto)
            {
                Console.WriteLine("El número secreto es mayor que {0}", numeroIntroducido);
            }
            else
            {
                adivinado = true;
                Console.WriteLine("¡Chilero! Has adivinado el número secreto: {0}", numeroSecreto);
            }
        }
    }
}