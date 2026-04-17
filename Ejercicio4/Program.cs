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

int[,] Numeros = new int[filas, columnas];

for (int i = 0; i < Numeros.GetLength(0); i++)
{
    for (int j = 0; j < Numeros.GetLength(1); j++)
    {
        bool Numerovalida = false;
        do
        {
            Console.Write("Ingrese un valor: ");
            if (!int.TryParse(Console.ReadLine(), out Numeros[i, j]))
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
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

int NumeroMayor = Numeros[0, 0];
int Posfila = 0;
int Poscolu = 0;

for (int i=0; i<Numeros.GetLength(0); i++)
{
    for (int j=0; j<Numeros.GetLength(1); j++)
    {
        if (Numeros[i, j] > NumeroMayor)
        {
            NumeroMayor = Numeros[i, j];
            Posfila = i;
            Poscolu = j;
        }
    }
}

Console.WriteLine($"El número mayor es {NumeroMayor} y se encuentra en la fila {Posfila + 1}, columna {Poscolu + 1}");