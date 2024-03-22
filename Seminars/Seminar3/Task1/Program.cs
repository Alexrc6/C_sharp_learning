
Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] mas = new string[n];
//double[] mas = new int[n];

Console.WriteLine(mas);

int ind = 0;
while (ind < mas.Length)
{
    Console.Write($"{mas[ind]} ");
    ind++;
}
Console.WriteLine();




// Console.Write("Введите размерность массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] mas = new int[n];

// Console.WriteLine(mas);

// int ind = 0;
// while (ind < mas.Length)
// {
//     Console.Write($"{mas[ind]} ");
//     ind++;
// }
// Console.WriteLine();