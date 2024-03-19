// Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.

// Console.WriteLine("Введите трехзначное число");
// int num = Convert.ToInt32(Console.ReadLine());

// int n3 = num % 10;
// int n2 = num % 100 / 10;

// double rais = Math.Pow(n2, n3);

// Console.WriteLine("Вторая цифра равна {0}, третья - {1}, вторая в степени третьей - {2}", n2, n3, rais);

Console.WriteLine("Введите трехзначное число");
string num = Convert.ToString(Console.ReadLine());
int n2 = Convert.ToInt32(num[1]);
int n2 = Convert.ToInt32(num[2]);

int rais = Math.Pow(n2, n3);
Console.WriteLine("Вторая цифра равна {0}, третья - {1}, вторая в степени третьей - {2}", n2, n3, ra