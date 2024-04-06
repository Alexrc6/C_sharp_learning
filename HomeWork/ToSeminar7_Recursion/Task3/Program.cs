// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

void CreateRandomMas(int MasLength, int[] SourceMas)
{
    if (MasLength == 0) return;
    Random rnd = new Random();
    SourceMas[MasLength - 1] = rnd.Next(0, 100);
    CreateRandomMas(MasLength - 1, SourceMas);
    return;
}

void PrintMas(int[] mas)
{
    if (mas.Length == 0) return;
    Console.Write($"{mas[0]} ");
    PrintMas(mas[1..]);
}

void PrintInwertedMas(int[] mas)
{
    if (mas.Length == 0) return;
    PrintInwertedMas(mas[1..]);
    Console.Write($"{mas[0]} ");
}

Console.Write("Укажите длину массива:\t");
int MasLength = Convert.ToInt32(Console.ReadLine());
int[] SourceMas = new int[MasLength];
CreateRandomMas(MasLength, SourceMas);

Console.Write("Исходный массив:\t");
PrintMas(SourceMas);

Console.WriteLine();
Console.Write("Перевернутый массив:\t");
PrintInwertedMas(SourceMas);
