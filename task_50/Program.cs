System.Console.Write("Введите количество строк M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов N: ");
int N = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите позицию элемента по горизонтали: ");
int PositionHorizontal = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите позицию элемента по вертикали: ");
int PositionVertical = Convert.ToInt32(Console.ReadLine());

int[,] my_array = new int[M, N];
int[,] CreateAndPrintMatrix(int[,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(0, 10);
        }
    }
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i,j]}, ");
        }
        System.Console.WriteLine();
    }
    return arr;
}

string GetPosition(int a, int b, int[,] arr)
{
    if(a >= 0 && a <= arr.GetLength(0) &&
       b >= 0 && b <= arr.GetLength(1))
       {
        int res = arr[a, b];
        return Convert.ToString(res);
       }
    return "Такого числа в массиве нет.";
}

CreateAndPrintMatrix(my_array);
System.Console.WriteLine($"{PositionHorizontal}, {PositionVertical} -> {GetPosition(PositionHorizontal, PositionVertical, my_array)}");