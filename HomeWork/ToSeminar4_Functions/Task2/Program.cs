// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


int[] CreateMas(int num)
{
    int[] mas = new int[num];
    Random rnd = new Random();
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = rnd.Next(100, 1000);
    }
    return mas;
}

void PrintMas(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        Console.Write($"{mas[i]} ");
    }
}

int CountEvenNum(int[] collection)
{
    
    int count = 0;
    foreach (int item in collection)
    {
        if (item % 2 == 0)
        {
            count++;
            //Console.Write($"{item} ");
        }
    }
    return count;
}




Console.Write("Введите N - длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] newMas = CreateMas(n);
PrintMas(newMas);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел: {CountEvenNum(newMas)}");