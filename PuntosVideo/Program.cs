using System.Xml.Schema;

int[] puntajes = new int[6];

for (int i = 0; i < puntajes.Length; i++)
{
    try
    {
        Console.Write($"Puntaje {i + 1}: ");
        puntajes[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        i--;
        continue;
    }

}

Array.Sort(puntajes);

Console.WriteLine($"Puntaje mas alto: {puntajes[5]} ");

int punt_500 = 0;
Console.WriteLine("Puntajes de menor a mayor: ");
foreach (int puntos in puntajes)
{
    Console.Write($"{puntos} ");
    if (puntos > 500)
    {
        punt_500++;
    }
}
Console.WriteLine($"\nContador de puntajes mayores a 500: {punt_500} ");
