//Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.


void CheckPosition(ref int m, ref int n)
{
    if (m > n)
    {
        int temp = n;
        n = m;
        m = temp;
    }
}

string CollectNaturalNumInTheRange(int m, int n)
{
    if (m == n) return Convert.ToString(n);
    return m + ", " + CollectNaturalNumInTheRange(m + 1, n);
}

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

//string str = "";
CheckPosition(ref m, ref n);
Console.Write($"Натуральный числа в промежутке от {m} до {n}: ");
Console.WriteLine(CollectNaturalNumInTheRange(m, n));


// void CheckPosition(ref int m, ref int n)
// {
//     if (m > n)
//     {
//         int temp = n;
//         n = m;
//         m = temp;
//     }
// }

// void PrintNaturalNumInTheRange(int m, int n)
// {
//     Console.Write($"{m} ");
//     if (m == n) return;
//     PrintNaturalNumInTheRange(m + 1, n);
// }

// Console.WriteLine("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());


// CheckPosition(ref m, ref n);
// Console.Write($"Натуральный числа в промежутке от {m} до {n}: ");
// PrintNaturalNumInTheRange(m, n);


