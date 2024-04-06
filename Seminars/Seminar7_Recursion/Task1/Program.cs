// Напишите программу, которая будет принимать 
// на вход число и возвращать сумму его цифр.


int CalcSumOfNumber(int n)
{
    int sum = 0;
    if(n == 0) return 0;
    //sum = sum + CalcSumOfNumber(n-1); 
    sum = n % 10 + CalcSumOfNumber(n / 10);
    return sum;
}

Console.WriteLine("Enter number N ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CalcSumOfNumber(n));























// int SumNum(int num)
// {
//     if (num == 0)
//     {
//         return 0;
//     }
//     Console.WriteLine(num);
//     int res = num % 10 + SumNum(num / 10);
//     return res;
// }


// Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SumNum(n));