// Задача 4**(не обязательно): Дано натуральное
// число в диапазоне от 1 до 100 000. Создайте массив,
// состоящий из цифр этого числа. Старший разряд
// числа должен располагаться на 0-м индексе
// массива, младший – на последнем. Размер массива
// должен быть равен количеству цифр.


using System;

class UserInputToCompileForTest
{
    public static int FindNumberLength(int numberInt)
    {
        int numberDigit = 0;
        while (numberInt > 0)
        {
            numberInt /= 10;
            numberDigit++;
        }
        return numberDigit;
    }

    public static int[] CreatingAnArray(int number)
    {
        int n = FindNumberLength(number);
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            int divider = Convert.ToInt32(Math.Pow(10, (n - 1 - i)));
            array[i] = number / divider;
            number = number % divider;
        }
        return array;
    }

    public static void PrintArray(int num)
    {
        foreach (var item in CreatingAnArray(num))
        {
            Console.Write($"{item} ");
        }
    }

    class Answer
    {
        public static void Main()
        {
            Console.WriteLine("Enter natural number from 1 to 100.000");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("An array of numbers has been created: ");
            UserInputToCompileForTest.PrintArray(num);
        }
    }
}

