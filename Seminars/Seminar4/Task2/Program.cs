// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.

int[] FillMasOfRand(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(1,1000);
    }
    return mas;
}

void PrintMas(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        Console.Write($"{mas[i]} ");
    }
}

int CountNum(int[] mas)
{
    int count = 0;
    for(int i = 0; i < mas.Length; i++)
    {
       if(mas[i] % 10 == 1 && mas[i] % 7 == 0) 
       {
        count++;
        Console.WriteLine(mas[i]);
       }
        
    }
    return count;
}



Console.WriteLine("Введите число N - длину массива");
int n = Convert.ToInt32(Console.ReadLine());

int[] mas = new int[n];
int[] newMas = FillMasOfRand(mas);


PrintMas(newMas);
Console.WriteLine();
Console.WriteLine(CountNum(newMas));








// Задайте массив из N случайных целых чисел (N вводится с клавиатуры).

// Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7.

// using System;

// int n=Convert.ToInt32(Console.ReadLine());

// int []arr= new int[n];
// int[] RandomMas(int[] col)
// {
//     for (int i = 0; i < col.Length; i++)
//     {
//         col[i] = new Random().Next(1,100);
//         Console.Write($"{col[i]},");
//     }
    
//     return col;
// }

// int Count(int[] col)
// {
//     int count = 0;

// for(int i=0;i<col.Length;i++){
// if(col[i]%10==1&&col[i]%7==0){
//   Console.WriteLine();  
// Console.Write($"Подпадающие числа:{col[i]} ");  
//   count++;}

// }
// return count;
 
// }

// int []mass=RandomMas(arr);
// int count=Count(mass);
// Console.WriteLine(); 
// Console.WriteLine($"Количество={count}");