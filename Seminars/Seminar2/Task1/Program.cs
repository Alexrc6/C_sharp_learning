// Напишите программу, которая принимает на
// вход трёхзначное число и удаляет вторую
// цифру этого числа.


int num = new Random().Next(100, 1000);
Console.WriteLine(num);

int a = num % 10;
int b = num / 100;
int num2 = b*10 + a;

Console.WriteLine("Первое число равно {0}, второе - {1}, новое число равно {2}", a, b, num2);
//Console.WriteLine(num2);