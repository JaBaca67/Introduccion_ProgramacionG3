// Crea un arrelgo de notas de 15 estudiantes, luego calcula el promedio de las notas, y los 3 primeros lugaes. No se puede ingresar notas menores a 0 o mayores a 100.

int[] notas = new int[15];

int suma = 0, countErrors = 0;
double promedio = 0;

for (int i = 0; i < notas.Length; i++)
{
    if (countErrors >= 3)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Te hace falta matria gris. Respia y oxigena y vuelve a nacer.");
        Console.ResetColor();
    }
    try
    {
        Console.WriteLine($"Ingrese la nota del estudiante {i + 1}:");
        int nota = int.Parse(Console.ReadLine()!);

        if (nota < 0 || nota > 100)
        {
            throw new ArgumentOutOfRangeException("La nota debe ser entre 0 y 100.");
        }
        notas[i] = nota;
    }

    catch (FormatException ex)
    {
        Console.WriteLine("Error: " + ex.Message);
        i--;
        countErrors++;
    }

    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine("Error: " + ex.Message);
        i--;
        countErrors++;
    }

    catch (Exception ex)
    {
        Console.WriteLine("Error: " + ex.Message);
        i--;
        countErrors++;
    }


}

foreach (int nota in notas)
{
    suma += nota;
}
promedio = suma / notas.Length;
Console.WriteLine($"La suma de las notas es: {suma}");
Console.WriteLine($"El numero de errores es: {countErrors}");
Console.WriteLine($"El promedio de las notas es: {promedio}");

Array.Sort(notas);
Array.Reverse(notas);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Cuadro de Honor");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(notas[i]);
}