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

double NumeroBuscar = 0;
bool BuscarValido = false;

do
{
    BuscarValido = false;
    Console.Write("Ingrese el número a buscar: ");
    if (!double.TryParse(Console.ReadLine(), out NumeroBuscar))
    {
        Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
        Console.WriteLine();
        BuscarValido = false;
    }
    else
    {
        BuscarValido = true;
    }
} while (!BuscarValido);


for (int i = 0; i < Numeros.GetLength(0); i++)
{
    for (int j = 0; j < Numeros.GetLength(1); j++)
    {
        if (Numeros[i, j] == NumeroBuscar)
        {
            Console.WriteLine("Si existe");
            Console.WriteLine();
            Console.WriteLine($"Se encuentra en la fila {i+1}, columna {j+1}");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
