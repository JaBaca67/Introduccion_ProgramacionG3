using System.Numerics;
using Microsoft.VisualBasic;

int[] vector1 = new int[5];
int[] vector2 = new int[5];

Console.WriteLine("Valores del vector 1: ");
for (int i = 0; i < vector1.Length; i++)
{
    try
    {
        Console.Write($"Valor {i + 1}: ");
        vector1[i] = int.Parse(Console.ReadLine()!);

        if (vector1[i] < 0)
        {
            Console.WriteLine("Error... ingrese el valor de nuevo");
            i--;
            continue;
        }
    }
    catch (FormatException)
    {
        i--;
        continue;
    }
}

Console.WriteLine("Valores del vector 2");

for (int i = 0; i < vector2.Length; i++)
{
    try
    {
        Console.Write($"Valor {i + 1}: ");
        vector2[i] = int.Parse(Console.ReadLine()!);

        if (vector2[i] < 0)
        {
            Console.WriteLine("Error vuelva a intentar");
            i--;
            continue;
        }
    }
    catch
    {
        i--;
        continue;
    }
}

int[] prodductovectores = new int[5];
int escalar = 0;

for (int i = 0; i < prodductovectores.Length; i++)
{
    prodductovectores[i] = vector1[i] * vector2[i];
}

foreach(int producto in prodductovectores)
{
    escalar += producto;
}

Console.WriteLine($"El producto escalar entre los vectores es de: {escalar}");