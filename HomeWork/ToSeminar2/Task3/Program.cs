// Задача 3: Напишите программу, которая принимает 
// на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

string num = Convert.ToString(new Random().Next(10, 100));
double number = 0;

for (int i = 0; i < num.Length; i++)
{
    number = number + (num[i] - 48) * Math.Pow(10, (num.Length - 1 - i));
}

int maxDigit = num[0];

foreach (int e in num)
{
    if (e > maxDigit)
    {
        maxDigit = e;
        //Console.Write($" {e} ");
    }
}

Console.WriteLine($"Максимальная цифра числа {number} равна - {maxDigit - 48}");