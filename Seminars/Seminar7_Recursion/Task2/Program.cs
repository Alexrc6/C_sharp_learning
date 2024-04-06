//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.


void PrintNaturalNumInInterval(int StopNum, int StartNum)
{
if(StopNum == StartNum - 1) return;

PrintNaturalNumInInterval(StopNum, StartNum + 1);
Console.Write($"{StartNum} ");
return;
}

Console.WriteLine("Enter number N: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintNaturalNumInInterval(n, 1);



























//Решение со строкой
// string Len(int stop, int start = -8)
// {
//     if (start == stop) return Convert.ToString(stop);
//     return start + " " + Len(stop, start + 1);
// }

// Console.WriteLine("Введите число ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Len(n));



//Решение с числами
// void Len2(int num)
// {
//     if (num == 0) return;
//      Console.Write($"{num} ");
//     Len2(num - 1);
   
// }

// Console.WriteLine("Введите число ");
// int n = Convert.ToInt32(Console.ReadLine());
// //Console.WriteLine(Len2(n));
// Len2(n);