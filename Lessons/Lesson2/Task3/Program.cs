// Создать целочисленный массив на 10
// элементов и заполнить его произвольными
// числами. Вывести на экран чётные элементы
// массива.

//int n = 10;
//int[] arr = new int [10]{2,5,6,4,7,4,3,6,7,3};




int[] numbers = { 4, 5, 6, 9, 2, 4, 7, 6, 3, 12 };
int i = 0;
// int Lenght2 = numbers.Length;
//Console.Write($"{numbers.Length} ");

while(i < numbers.Length)
{
    if (numbers[i] % 2 == 0)
    {
        Console.Write($"{numbers[i]} ");

    }
    i = i + 1;

}
   






// using System;

// class Program
// {
//     static void Main()
//     {
//         // Объявляем и инициализируем массив целых чисел
//         int[] numbers = { 1, 2, 3, 4, 5 };

//         // Получаем длину массива с помощью свойства Length
//         int length = numbers.Length;

//         // Выводим длину массива на экран
//         Console.WriteLine("Длина массива numbers: " + length);
//     }
// }