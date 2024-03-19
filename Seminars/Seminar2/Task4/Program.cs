// Напишите программу, которая выводит третью с
// конца цифру заданного числа или сообщает, что
// третьей цифры нет.

int Num = new Random().Next(0,100000);
//int Num = 100;

for (int i = 0; i < 1; i++)
{
    if (Num % 100 > 0 || Num == 100)
    {
        int res = (Num % 1000 - Num % 100) / 100;
        Console.WriteLine("исходное {0}, третья с конца цифра {1}", Num, res);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");

    }
}







// using System;


//  // int num = new Random().Next(0,10000);

// int num = 7739;
// Console.WriteLine(num);
// int res=0;
// if(num<100){Console.WriteLine($"третей цифры нет:{num}");}else{

// while(num>=100){
//  res=num%10; 
//  num/=10;
// Console.WriteLine($"ответ:{res}");


// }

// }