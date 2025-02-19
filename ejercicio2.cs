using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese su sexo (M/F): ");
        char sexo = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine("\nIngrese su edad: ");
        
        if (int.TryParse(Console.ReadLine(), out int edad) && edad > 0)
        {
            double pulsaciones = (sexo == 'F') ? (220 - edad) / 10.0 : (210 - edad) / 10.0;
            Console.WriteLine($"Debe tener {pulsaciones:F2} pulsaciones cada 10 segundos de ejercicio.");
        }
        else
        {
            Console.WriteLine("Edad inválida.");
        }
    }
}
