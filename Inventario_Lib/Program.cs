using System.Diagnostics.Contracts;

int[] libros = new int[5];
int total_libros = 0;
string mayor_cateogoria = "";
int mayor_venta = 0;

for (int i = 0; i < libros.Length; i++)
{
    try
    {
        Console.Write($"Libros vendidos en la categoria {i + 1}: ");
        libros[i] = int.Parse(Console.ReadLine()!);

        if (libros[i] < 0)
        {
            i--;
            continue;
        }

        total_libros += libros[i];

        if (libros[i] > mayor_venta)
        {
            mayor_venta = libros[i];
        }
    }
    catch (FormatException)
    {
        i--;
        continue;
    }
}

Console.WriteLine($"\nEl total de libros vendidos es de: {total_libros}");
double promedio = (double)total_libros / libros.Length;
Console.WriteLine($"El promedio total de libros vendidos es de: {promedio}");

int contador = 0;

for (int i = 0; i < libros.Length; i++)
{
    if (libros[i] == mayor_venta)
    {
        mayor_cateogoria += $"{i + 1} ";
        contador++;
    }
}

if (contador > 1)
{
    Console.WriteLine($"\nLas categorias ganadoras son: {mayor_cateogoria}.\nCon un total vendido de: {mayor_venta}");
}
else
{
    Console.WriteLine($"La categoria ganadora es la categoria: {mayor_cateogoria}\nCon un total vendido de: {mayor_venta}");
}


