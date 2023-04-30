System.Console.Write("Введите количество строк M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов N: ");
int N = Convert.ToInt32(Console.ReadLine());


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
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        System.Console.Write($"{arr[i]}, ");
    }
}

void GetMean(int[,] arr)
{
    double[] arr_mean = new double[arr.GetLength(1)];
    
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum+=arr[i,j];
        }
        double mean = sum/arr.GetLength(0);
        arr_mean[j] = mean;
    }
    PrintArray(arr_mean);
}

CreateAndPrintMatrix(my_array);
System.Console.WriteLine();
System.Console.Write($"Среднее арифметическое каждого столбца: ");
GetMean(my_array);