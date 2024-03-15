Console.WriteLine("Введите трехзначное число: ");
string n = Console.ReadLine()!;

if (n.Length != 3)
{
    Console.WriteLine("Это не трехзначное число...");
}
else
{
    Console.WriteLine(Convert.ToString(n[0]) + Convert.ToString(n[2]));
}
// int a1 = Num % 10;
// int a2 = Num / 10 % 10;
// int a3 = Num / 100;

// int sum = a1 + a3;
//Console.WriteLine($"Сумма первого и последнего чисел {a1} и {a3}: {sum}");