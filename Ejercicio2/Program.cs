int filas = 0;
int columnas = 0;

do
{
    Console.Write("Ingrese el número de filas: ");
    if (!int.TryParse(Console.ReadLine(), out filas) || filas <= 0)
    {
        Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero positivo para las filas.");
        Console.WriteLine();
    }
} while (filas <= 0);


do
{
    Console.WriteLine();
    Console.Write("Ingrese el número de columnas: ");
    if (!int.TryParse(Console.ReadLine(), out columnas) || columnas <= 0)
    {
        Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero positivo para las columnas.");
    }
} while (columnas <= 0);

Console.WriteLine();
Console.WriteLine("Presione cualquier tecla para continuar");
Console.ReadKey();
Console.Clear();

double[,] Numeros = new double[filas, columnas];

for (int i = 0; i < Numeros.GetLength(0); i++)
{
    for (int j = 0; j < Numeros.GetLength(1); j++)
    {
        bool Numerovalida = false;
        do
        {
            Console.Write("Ingrese un valor: ");
            if (!double.TryParse(Console.ReadLine(), out Numeros[i, j]))
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
                Console.WriteLine();
            }
            else
            {
                Numerovalida = true;
                Console.WriteLine();
            }
        } while (!Numerovalida);
    }
}

Console.WriteLine();
Console.WriteLine("Presione cualquier tecla para continuar");
Console.ReadKey();
Console.Clear();

int FilaMostrar = 0;
do
{
    Console.Write("Ingrese la fila a mostrar: ");
    if (!int.TryParse(Console.ReadLine(), out FilaMostrar) || FilaMostrar <= 0 || FilaMostrar > filas)
    {
        Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido para la fila.");
        Console.WriteLine();
    }
} while (FilaMostrar <= 0 || FilaMostrar > filas);
Console.WriteLine();
for (int j = 0; j < Numeros.GetLength(1); j++)
{
    Console.Write($"{Numeros[FilaMostrar - 1, j]}  ");
}
Console.WriteLine();
