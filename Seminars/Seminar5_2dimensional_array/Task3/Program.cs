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


//типизация???
// public static class CollectionExtensions
// {
//     static void Print<T>(this ICollection<T> list)
//     {
//         foreach (T item in list)
//         {
//             Console.WriteLine(item);
//         }
//     }
// }

//функция с обобщениями
// void Print<T>(T[] list)
// {
//     foreach(var i in list)
//     {
//         Console.WriteLine(i);
//     }
// }




//код Марины
// int[,] num1 = {{2, 32, 4, 3}, {4, 3, 12, 1}, {2, 8, 5, 4}};

//  int[] Sum (int[,] num1)
//  { int[] summa = new int [num1.GetLength(0)];
   
//     for ( int i = 0; i < num1.GetLength(0); i++)
//     { int sum = 0;

//         for ( int j = 0; j < num1.GetLength(1); j++)
//         {
//             sum = sum + num1[i, j];
            
//         }
//          summa[i] = sum; 
//     }
//     return summa;
//  }


// void Print(int[] arr)
// {
//     for ( int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($" {arr[i]}" );
//     }
//     Console.WriteLine();
// } 


// void Print2(double[] arr)
// {
//     for ( int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($" {arr[i]}" );
//     }
//     Console.WriteLine();
// }

// double[] Middle (int[] a, int[,] b)
// {
//     double[] c = new double[b.GetLength(0)];
//     for( int i = 0; i < a.Length; i++)
//     {
//        c[i] = Convert.ToDouble(a[i]) / Convert.ToDouble(b.GetLength(1));
//     }
//     return c;
// }




// int[] num2 = Sum(num1); // после всех циклов функции Sum вернулся одномерный массив  сохранен в этот массиве
// Print(num2);

// double[] num3 = Middle(num2, num1);
// Print2(num3);