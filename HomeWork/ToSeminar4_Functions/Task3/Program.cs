// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

int[] CreateMas(int lengthMas)
{
    int[] mas = new int[lengthMas];
    Random rnd = new Random();
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = rnd.Next(1, 1000);
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

int[] FlipArray(int[] mas)
{
    int[] invertedMas = new int[mas.Length];
    for (int i = 0; i < mas.Length; i++)
    {
        invertedMas[i] = mas[mas.Length - 1 - i];
    }
    return invertedMas;
}

Console.WriteLine("Введи N - длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] NewMas = CreateMas(n);
PrintMas(NewMas);
Console.WriteLine();
int[] invertedNewMas = FlipArray(NewMas);
PrintMas(invertedNewMas);

