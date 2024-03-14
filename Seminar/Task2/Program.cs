Console.WriteLine("Введите целое положительное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int notN = -N;
while(notN <= N)
{
    Console.Write($"{notN} ");
    notN++;
}

