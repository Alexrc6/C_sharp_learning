Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
//string[] mas = new string[n];
int[] mas = new int[n];
//double[] mas = new double[n];

Console.WriteLine(mas);

int ind = 0;
while (ind < mas.Length)
{
    Console.Write($"{mas[ind]} ");
    ind++;
}
Console.WriteLine();

for (int i = 0; i < mas.Length; i++)
{
    Console.Write($"{mas[i]} ");
}
Console.WriteLine();

foreach (int e in mas)
{
    Console.Write($"{e} ");
}
Console.WriteLine();

//function

void PrintMas(int[] col)
{
    foreach (int e in col)
    {
        Console.Write($"{e} ");
    }
}

PrintMas(mas);

Console.WriteLine();


int[] RandomMas(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(1, 9);
    }

    return col;
}

int[] new_mas = RandomMas(mas);
PrintMas(new_mas);



// int flag = 0;
// foreach (var item in new_mas)
// {
//     if (item == 5)
//     {
//       flag++;
//     }
    
// }

// if (flag > 0)
// {
//     Console.WriteLine
// }

// bool Check(int[] list)
// {
//     var num = int.Parse(Console.ReadLine());

//     foreach (int item in list)
//     {
//         if (item == num) 
//         { 
//             return true;
//         }
//     }

//     return true;
// }