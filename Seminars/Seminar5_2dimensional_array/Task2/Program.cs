// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int[,] CreateRandomMas(int[,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(0, 10);
        }
    }
    return arr;
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

int CalcSumElemOnDiag(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < Math.Min(arr.GetLength(0), arr.GetLength(1)); i++)
    {

        // for (int j = 0; j < arr.GetLength(1); j++)
        // {
        //    if(i == j)
        //    {
        //     sum += arr[i,j];
        //    }
        // }
        sum += arr[i, i]; //если так, то надо дополнить функцией по определению, 
                          //что меньше строка или столбец, чтобы поставить 
                          //ограничение по перебору и не выйти за границу массива

    }
    return sum;
}


Console.Write("Введи M - количество строк:    ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи N - количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];

int[,] NewArr = CreateRandomMas(arr);
PrintArr(NewArr);
Console.WriteLine();
Console.Write(CalcSumElemOnDiag(NewArr));

// int[,] arrNew2 = {{2,3,4,1},{2,3,5,3}}; //запись известного массива
// Console.WriteLine();
// PrintArr(CalcSQR(arrNew2));