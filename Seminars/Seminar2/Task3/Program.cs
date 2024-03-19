// Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.


string Test(int first, int second)
{
    if (second == 0) {return "Деление на 0!";}

    int res = first % second;

    if (res == 0)
    {
        return "Четное";
    }
    {
        return $"Не четное, {res}";
    }
}

int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Test(num1,num2));




// Console.WriteLine("Введите два трехзначных числа");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(:)