// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.

int[,] CreateRandomMas(int[,] arr)
{
   Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           arr[i,j] = rnd.Next(0,10);
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
           Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }  
}

int[,] CalcSQR(int[,] arr)
{
   Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           if(i % 2 == 0 && j % 2 == 0)
           {
            arr[i,j] = arr[i,j]*arr[i,j];
           }
        }
        return arr;
    }
    return arr;
}


Console.Write("Введи M - количество строк:    ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи N - количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n]; 

int[,] NewArr = CreateRandomMas(arr);
PrintArr(NewArr);
Console.WriteLine();
PrintArr(CalcSQR(NewArr));

int[,] arrNew2 = {{2,3,4,1},{2,3,5,3}}; //запись известного массива
Console.WriteLine();
PrintArr(CalcSQR(arrNew2));
