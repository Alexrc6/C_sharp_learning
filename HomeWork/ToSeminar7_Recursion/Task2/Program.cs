//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

double CalcAkkermanFunction(double m, double n)
{
    if (m > 0 && n > 0)
    {
        return CalcAkkermanFunction(m - 1, CalcAkkermanFunction(m, n - 1));
    }
    else if (m > 0 && n == 0)
    {
        return CalcAkkermanFunction(m - 1, 1);
    }
    else if (m == 0)
    {
        return n + 1;
    }
    return 0;
}

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Значение функции Аккермана = {CalcAkkermanFunction(m, n)}");
