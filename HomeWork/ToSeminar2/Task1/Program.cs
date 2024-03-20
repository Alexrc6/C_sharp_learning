// Задача 1: Напишите программу, которая принимает
//  на вход число и проверяет, кратно ли оно одновременно 7 и 23.


//Console.WriteLine("Введите целое число");
//int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите любое число");
double num = Convert.ToDouble(Console.ReadLine());

if (num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine($"Число {num} кратно одновременно 7 и 23");
}
else
{
    Console.WriteLine($"Число {num} не кратно одновременно 7 и 23");
}




