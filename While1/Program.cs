/* Leer un numero entero y mostrar todos sus antesores elevados al cubo */
using Math = System.Math;
int numero;

while (true)
{
    Console.Write("Ingrese un numero entero: ");
    if (int.TryParse(Console.ReadLine()!, out numero) && numero >= 1)
    {
        break;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada no valida, Por favor, ingrese un numero entero");
        Console.ResetColor();
    }
}
    Console.WriteLine("Los antecesores elevados al cubo son");

    int contador = 1;
    while (contador < numero)
    {
        double cubo = Math.Pow(contador, 3);
        Console.WriteLine($"{contador} elevado al cubo = {cubo}");
        contador++;
    }
