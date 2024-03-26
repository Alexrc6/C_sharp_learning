// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем. 

int[] FillMasRandom(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(1,10);
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

int CreateNumFromMas(int[] mas)
{
    int number = mas[0];
    for (int i = 1; i < mas.Length; i++)
    {
        number = number*10 + mas[i];
    }
    return number;
}

Console.WriteLine("Введите n - длину массива (не более 8)");
int  n = Convert.ToInt32(Console.ReadLine());

int[] mas = new int[n];
int[] newMas = FillMasRandom(mas);

PrintMas(newMas);
Console.WriteLine();
Console.WriteLine(CreateNumFromMas(newMas));













//еще один вариант
// using System.Security.Cryptography;

// int[] RandomMass(int m)
// {
//     int[] Number = new int[m];
//     for (int i = 0; i < Number.Length; i++)
//     {
//         Number[i] = new Random().Next(0,9);
//         Console.Write($"{Number[i]}, ");
//     }
//     return Number;
// }

// //функцию для подбора
// string FindFirstAndLast(int[] col)
// {
//     string number = "";
//     for (int i = 0; i < col.Length; i++)
//     {
//         number = number + Convert.ToString(col[i]);
        
//     }
//     return number;
// }

// //это для ввода размерности
// Console.Write("Введите размерность массива не более 8: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] arr = RandomMass(n);
// string str = FindFirstAndLast(arr);
// Console.WriteLine();
// Console.WriteLine(str);





//Код Артема
// void ListWriter(int n)
// {
//     int[] list = new int[n];
//     int i = 0;
//     while (i < n)
//     {
//         int num = int.Parse(Console.ReadLine());
//         if (num >= 0 || num < 10)
//         {
//             list[i] = num;
//         }

//         i++;
//     }
//     Console.WriteLine(NumWriter(list));
// }

// int NumWriter(int[] list)
// {
//     int res = 0;
//     foreach(int num in list)
//     {
//         res *= 10;
//         res += num;
//     }

//     return res;
// }

// int n = int.Parse(Console.ReadLine());

// if (n <= 8)
// {
//     ListWriter(n);
// }