using System.Linq.Expressions;
using System.Numerics;

int[] vector1 = new int[5];
int[] vector2 = new int[5];
int[] RestaVector = new int[5];

Console.WriteLine("Por favor, ingrese los valores del primer vector");

for (int i = 0; i < vector1.Length; i++)
{
    try
    {
        Console.Write($"Valor {i + 1}: ");
        vector1[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Valor invalido, intente de nuevo");
        i--;
        Console.ResetColor();
    }
}

Console.WriteLine("Por favor, ingrese los valores del segunod vector");

for (int i = 0; i < vector2.Length; i++)
{
    try
    {
        Console.Write($"Valor {i + 1}: ");
        vector2[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Valor invalido, intente de nuevo");
        i--;
        Console.ResetColor();
    }
}

for (int i = 0; i < RestaVector.Length; i++)
{
    RestaVector[i] = vector1[i] - vector2[i];
}

Console.WriteLine("Resta de Vectores");
for (int i = 0; i < RestaVector.Length; i++)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"Valor {i + 1}: {RestaVector[i]}");
    Console.ResetColor();
}