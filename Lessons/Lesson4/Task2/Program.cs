// Задача №2
// • Назовём число «интересным» если его сумма цифр чётная
// • Создать двумерный массив, состоящий из целых чисел. Вывести на экран «интересные» элементы массива

int FindSumOfDigitalNum(int num)
{
    int sumDigital = 0;
    while (num > 0)
    {
        sumDigital = sumDigital + num % 10;
        num /= 10;
    }
    return sumDigital;
}

void FindAndPrintIntrestingMas(int[,] matrix)
{
    Console.Write("Интересные числа: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int sumDig = FindSumOfDigitalNum(matrix[i, j]);
            if (sumDig % 2 == 0)
            {
                Console.Write($"{matrix[i,j]} ");
            }
        }
    }
}


int[,] CreateMatrixRandom(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
         Console.WriteLine();
    }
}


int[,] matrix = CreateMatrixRandom(5, 6);
PrintMatrix(matrix);
Console.WriteLine();
FindAndPrintIntrestingMas(matrix);
