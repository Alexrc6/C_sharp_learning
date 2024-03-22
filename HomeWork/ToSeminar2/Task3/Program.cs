// Задача 3: Напишите программу, которая принимает 
// на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

//Проработка нового варианта. В работе
using System;

class Program
{
    static void Main()
    {

        string num = Convert.ToString(new Random().Next(10, 1000));
        int number = Convert.ToInt32(num);


        int maxDigit = num[0];

        foreach (int e in num)
        {
            if (e > maxDigit)
            {
                maxDigit = Convert.ToInt32(e);
            }
        }
        Console.WriteLine($"num = {num} num.Length = {num.Length}");
        Console.WriteLine($"Максимальная {num} цифра {num.Length} числа {number} равна - {maxDigit}");

    }
}

// using System;

// class Program
// {
//     static void Main()
//     {

//         string num = Convert.ToString(new Random().Next(10, 100));
//         double number = 0;

//         for (int i = 0; i < num.Length; i++)
//         {
//             number = number + (num[i] - 48) * Math.Pow(10, (num.Length - 1 - i));
//         }

//         int maxDigit = num[0];

//         foreach (int e in num)
//         {
//             if (e > maxDigit)
//             {
//                 maxDigit = e;
//                 //Console.Write($" {e} ");
//             }
//         }

//         Console.WriteLine($"Максимальная цифра числа {number} равна - {maxDigit - 48}");

//     }
// }



//Второй вариант

// using System;

// class Program
// {
//     static void Main()
//     {

//         Console.Write("Введите число из отрезка [10, 99]");
//         int num = Convert.ToInt32(Console.ReadLine());

//         int firstDigit = num % 10;
//         int secondDigit = num / 10;

//         int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;

//         Console.WriteLine($"Максимальная цифра числа {num} равна - {maxDigit}");

//     }
// }