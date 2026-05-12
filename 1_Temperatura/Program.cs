using System.Diagnostics.CodeAnalysis;

int[] temperaturas = new int[7];
int suma = 0;

for (int i = 0; i < temperaturas.Length; i++)
{
    try
    {
        Console.Write($"Valor de la temperatura {i + 1}: ");
        temperaturas[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.WriteLine("Error.");
        i--;
        continue;
    }

}


Console.WriteLine("Temperaturas Registrada: ");
foreach (int temp in temperaturas)
{
    Console.Write($"{temp} ");
    suma += temp;

}

double promedio;

promedio = suma / temperaturas.Length;

int tempmayor = temperaturas[0];
int tempmenor = temperaturas[0];

for (int i = 0; i < temperaturas.Length; i++)
{
    if (tempmayor < temperaturas[i])
    {
        tempmayor = temperaturas[i];
    }
    if (tempmenor > temperaturas[i])
    {
        tempmenor = temperaturas[i];
    }

}

Console.WriteLine($"\nLa temperatura mayor registrada fue: {tempmayor} ");
Console.WriteLine($"La temperatura menor registrada fue: {tempmenor}");
Console.WriteLine($"Promedio: {promedio}");