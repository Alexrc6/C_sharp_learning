﻿using System;

public class Answer {
    
  static int FindMax(int a, int b, int c)
    {
      // Введите свое решение ниже
      // Внутри класса Answer напишите метод FindMax, 
      // который принимает на вход три числа и выдаёт максимальное из этих чисел.
      

    int max = a;
    if(max < b)
    {
        max = b;
    }
    if (max < c)
    {
        max = c;
    }
    return max;

    }

  // Не удаляйте и не меняйте метод Main! 
  static public void Main(string[] args) {
        int a, b, c;

        if (args.Length >= 3) {
           a = int.Parse(args[0]);
           b = int.Parse(args[1]);
           c = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           a = 8;
           b = 11;
           c = 9;
        }

        // Не удаляйте строки ниже
        int result = FindMax(a, b, c);
        System.Console.WriteLine($"{result}");
    }
}