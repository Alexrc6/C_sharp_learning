Console.WriteLine("Введите трехзначное число: ");
int Num = Convert.ToInt32(Console.ReadLine());

int a1 = Num % 10;
int a2 = Num / 10 % 10;
int a3 = Num / 100;

int sum = a1 + a3;
Console.WriteLine($"Сумма первого и последнего чисел {a1} и {a3}: {sum}");