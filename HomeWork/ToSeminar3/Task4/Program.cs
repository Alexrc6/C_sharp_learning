// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.

int n = 10;
int[] mas = new int[n];

int[] RandMas(int[] col)
{
    for(int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(-10,11);
    }
    return col;
}


void PrintMas(int[] col)
{
    foreach (int item in col)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

int[] arr = RandMas(new int[n]);

PrintMas(arr);

for (int i = 0; i < arr.Length; i++)
{
    arr[i] *= -1;
}

PrintMas(arr);



// using System.ComponentModel.DataAnnotations;

// int n = Convert.ToInt32(Console.ReadLine());

// void PrintMas(int[] col)
// {
//     foreach (int item in col)
//     {
//         Console.Write($"{item} ");
//     }
//     Console.WriteLine();
// }


// int[] RandomMas(int[] col)
// {
//     for (int i = 0; i < col.Length; i++)
//     {
//         col[i] = new Random().Next(-10,11);
//     }
    
//     return col;
// }

// int[] arr=RandomMas(new int[n]);
//   PrintMas(arr);

//   for (int i=0;i<arr.Length;i++){
//     arr[i]*=-1;

//   }

// PrintMas(arr);