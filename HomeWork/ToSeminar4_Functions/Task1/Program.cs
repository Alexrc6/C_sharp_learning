// Задача 1: Напишите программу, которая бесконечно запрашивает 
// целые числа с консоли. Программа завершается при вводе 
// символа ‘q’ или при вводе числа, сумма цифр которого чётная.

bool FinishIfQorEven(string sign)
{
    if (String.Compare(sign, "q") == 0 || SignCheckEven(sign) == true) // String.Compare сравнивает sign и "q", если они равны, выводит 0
    {
        Console.WriteLine("Программа завершена");
        return false;
    }
    return true;
}

bool SignCheckEven(string num)
{
    bool flag = false;
    int convNum = FindSumDigital(num);
    if (convNum % 2 == 0)
    {
        flag = true;
    }
    return flag;
}

int FindSumDigital(string num)
{
    int number = Convert.ToInt32(num);
    int NewNum = 0;
    while (number > 0)
    {
        NewNum = NewNum + number % 10;
        number /= 10;
    }
    return NewNum;
}

bool flag = true;

while (flag == true)
{
    Console.Write("Введите целое число: ");
    string n = Convert.ToString(Console.ReadLine());
    flag = FinishIfQorEven(n);
}

