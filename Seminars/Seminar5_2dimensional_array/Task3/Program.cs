// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива. 


int[,] CreateRandomArr(int RowLength, int ColLength)
{
    int[,] Arr = new int[RowLength,ColLength];
    Random rnd = new Random();

    for (int i = 0; i < RowLength; i++)
    {
        for (int j = 0; j < ColLength; j++)
        {
            Arr[i,j] = rnd.Next(0, 10);
        }
    }
    return Arr;

}

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}


double[] FindAverageInRow(int[,] arr)
{
    double[] masAve = new double[arr.GetLength(0)];
    double sum = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        masAve[i] = sum / arr.GetLength(1);
        sum = 0;
    }
    return masAve;
}

void PrintMas(double[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        Console.WriteLine($"{mas[i]}");
    }
}

int[,] newArr = CreateRandomArr(5, 5);
PrintArr(newArr);
Console.WriteLine("Средние значения значений строк:");
PrintMas(FindAverageInRow(newArr));




