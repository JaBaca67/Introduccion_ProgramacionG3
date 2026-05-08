using System.Numerics;

int[] vector1 = new int[5];
int[] vector2 = new int[5];
int[] vectorSuma = new int[5];
Console.WriteLine("Por favor ingrese los valores del primer vector");
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
        Console.WriteLine("Entrada no valida. Por favor ingrese un numero entero");
        Console.ResetColor();
        i--;
    }

}

Console.WriteLine("Por favor ingrese los valores del segundo vector");
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
        Console.WriteLine("Entrada no valida. Por favor ingrese un numero entero");
        Console.ResetColor();
        i--;
    }
}

//Sumar los vetores
for (int i = 0; i < vectorSuma.Length; i++)
{
    vectorSuma[i] = vector1[i] + vector2[i];
}

//Mostrar arreglo resultante
Console.WriteLine("Suma de los vectores: ");
for (int i = 0; i < vectorSuma.Length; i++)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"Valor {i + 1}: {vectorSuma[i]}");
}

Console.Write("Componetes vector 1: ");
foreach (int componentes1 in vector1)
{
    Console.Write($"{componentes1} ");
}

Console.Write("\nComponetes vector 2: ");
foreach (int componentes2 in vector2)
{
    Console.Write($"{componentes2} ");
}