using System;

class Program
{
    static void Main(string[] args)
    {
        string cadena = "Hola Universitarios";

        int longitud = cadena.Length;
        Console.WriteLine("Longitud de la cadena "+ longitud);

        string mayusculas = cadena.ToUpper();   
        string minusculas = cadena.ToUpper();
        Console.WriteLine("En Mayusculas" + mayusculas);
        Console.WriteLine("En Minusculas" + minusculas);

        int indicePrimerpaso = cadena.IndexOf("m");
        int indiceultimopaso = cadena.LastIndexOf("o");
        Console.WriteLine("Primer paso de m" + indicePrimerpaso);
        Console.WriteLine("Ultimo paso de o" + indiceultimopaso);

        string subcadena = cadena.Substring(6, 5);
        Console.WriteLine("Subcadena " + subcadena);

        string nuevacadena = cadena.Replace("UMG", "UMG Jutiapa");
        Console.WriteLine("Nueva Cadena " + nuevacadena);

        string cadenaconespacios = "    Shukos    ";
        string cadenasinespacios = cadenaconespacios.Trim();
        Console.WriteLine("Cadena Sin Espacios " + cadenasinespacios + "");

        bool empecemosconhola = cadena.StartsWith("Hola");
        bool termineconexclamacion = cadena.EndsWith("!");
        Console.WriteLine("Empezamos con Hola? " + empecemosconhola);
        Console.WriteLine("Terminamos Con Exclamacion '!' ? " + termineconexclamacion);

        string otracadena = "Hola Catedratico";
        bool iguales = cadena.Equals(otracadena, StringComparison.OrdinalIgnoreCase);
        Console.WriteLine("Son Iguales? " + iguales);

        string unicaconcatenacion = cadena + " " + otracadena;
        Console.WriteLine(" Concatenacion " + unicaconcatenacion);

        bool holaguardado = cadena.Contains("Hola");
        Console.WriteLine(" ContieneHola? " + holaguardado);

        int numero = 30;
        string cadenaFormateo = string.Format("El numero es {0}", numero);
        Console.WriteLine("El Formateo de Cadena " + cadenaFormateo);
    }
}