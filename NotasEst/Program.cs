using System.Diagnostics.CodeAnalysis;

int [] notas = new int [8];

for(int i = 0; i < notas.Length; i++)
{
    try
    {
        Console.Write($"Nota {i+1}: ");
        notas[i] = int.Parse(Console.ReadLine()!);

        if(notas[i] < 0 || notas[i] > 100)
        {
            i--;
            continue;
        }
    }
    catch(FormatException)
    {
        i--;
        continue;
    }
}
int reprobados = 0, suma_notas = 0;

Console.WriteLine("Notas aprobadas: ");
foreach(int nota in  notas)
{
    if (nota > 70)
    {
        Console.Write($"{nota} ");
    }
    else if(nota < 70)
    {
        reprobados++;
    }
    suma_notas += nota;
}

double promedio = (double)suma_notas / notas.Length;
Console.WriteLine($"\n El total de reprobados es: {reprobados}");
Console.WriteLine($"Promedio general: {promedio}");