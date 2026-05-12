double[] ventas = new double[7];
double total = 0;
int superan150 = 0;

// Pedir datos
for (int i = 0; i < 7; i++)
{
    Console.Write($"Venta día {i + 1}: ");
    ventas[i] = double.Parse(Console.ReadLine()!);
}

// Empezamos asumiendo que la primera venta es la más baja
double ventaBaja = ventas[0];

// Procesar datos
foreach (double v in ventas)
{
    total += v;
    if (v > 150) superan150++;
    if (v < ventaBaja) ventaBaja = v;
}

// Resultados
Console.WriteLine("\n--- RESUMEN ---");
Console.WriteLine($"Total: {total}");
Console.WriteLine($"Días > 150: {superan150}");
Console.WriteLine($"Venta más baja: {ventaBaja}");