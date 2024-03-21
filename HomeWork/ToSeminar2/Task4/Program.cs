// Задача 4: Напишите программу, которая на вход 
// принимает натуральное число N, а на выходе 
// показывает его цифры через запятую.

using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Введите любое натуральное число");
        int nInt = Convert.ToInt32(Console.ReadLine());
        int countN = 0;
        int tempNInt = nInt;

        //Определения количества цифр в числе (потребуется для задания массива определенной длины)
        while (tempNInt > 0)
        {
            countN++;
            tempNInt = tempNInt / 10;
        }
        //Console.WriteLine($"Число {nInt} - {countN} значное");

        //Запись числа в массив
        tempNInt = nInt;
        int[] stringN = new int[countN];

        for (int i = (countN - 1); i >= 0; i--)
        {
            stringN[i] = tempNInt % 10;
            tempNInt = tempNInt / 10;
            //Console.Write("Записано {0}", tempNInt);    
        }
        Console.Write("Исходное число: {0}", nInt);

        //Вывод минизаголовка
        if (stringN.Length < 2)
        {
            Console.Write(". Оно содержит цифру: ");
        }
        else
        {
            Console.Write(". Оно содержит цифры: ");
        }

        //Вывод всех цифр кроме последней + запятая и пробел в конце
        for (int i = 0; i < stringN.Length - 1; i++)
        {
            Console.Write($"{stringN[i]}, ");
        }
        //Вывод последней цифры (без запятой в конце)
        Console.Write($"{stringN[stringN.Length - 1]}");

    }
}


// Вариант 2
// string num = Convert.ToString(new Random().Next(0, 100000));

// Console.Write("Исходное число: ");
// foreach (int e in num)
// {
//     Console.Write(e - 48);
// }

// if (num.Length < 2)
// {
//     Console.Write(". Оно содержит цифру: ");
// }
// else
// {
//     Console.Write(". Оно содержит цифры: ");
// }

// for (int i = 0; i < num.Length - 1; i++)
// {
//     Console.Write($"{num[i] - 48}, ");
// }

// Console.Write($"{num[num.Length - 1] - 48}");