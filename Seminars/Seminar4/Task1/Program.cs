// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.

int[] RandomMas(int m)
{
    int[] Number = new int[m];
    for (int i = 0; i < Number.Length; i++)
    {
        Number[i] = new Random().Next(1, 100);
    }
    return Number;
}

void PrintMas(int[] collection)
{
    foreach (var item in collection)
    {
        Console.Write($"{item} ");

    }
    Console.WriteLine();
}

bool Prost(int num)
{
    for (int i = 2; i < num; i++)
    {
        if (num % i == 0) return false;
    }
    Console.WriteLine(num);
    return true;
}

int Count(int[] col)
{
    int count = 0;
    foreach (var i in col)
    {
        if (Prost(i)) count++;
    }
    return count;
}





Console.WriteLine("Введите размерность массива");
int n = Convert.ToInt32(Console.ReadLine());

int[] mas = RandomMas(n);
PrintMas(mas);
Console.WriteLine($"Количество простых чисел в массиве равно {Count(mas)}");

