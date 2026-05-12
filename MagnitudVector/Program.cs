//Magnitud de Vectores.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

int[] vector = new int[5];
int[] cuadarado = new int[5];

for (int i = 0; i < vector.Length; i++)
{
    try
    {
        Console.Write($"Valor {i + 1} del vector: ");
        vector[i] = int.Parse(Console.ReadLine()!);

        if (vector[i] < 0)
        {
            Console.WriteLine("Error, vuelva a intentar");
            i--;
            continue;
        }
        cuadarado[i] = (vector[i]) * (vector[i]);
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Valor invalido, intente de nuevo");
        i--;
        Console.ResetColor();
    }
}

int suma = 0;
foreach(int elemento in cuadarado)
{
    suma += elemento;
}

double Magnitud;
Magnitud = Math.Sqrt(suma);
Console.WriteLine($"La magnitud del vector es de: {Magnitud:N2}");
