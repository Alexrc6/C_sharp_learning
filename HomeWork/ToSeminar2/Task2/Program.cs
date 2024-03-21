// Задача 2: Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт 
// номер координатной четверти плоскости, в которой находится эта точка.

using System;

class Program
{
    static void Main()
    {

        // Console.WriteLine("Введите координату точки X (Х ≠ 0)");
        // Double varX = Convert.ToDouble(Console.ReadLine());

        // Console.WriteLine("Введите координату точки Y (Y ≠ 0)");
        // Double varY = Convert.ToDouble(Console.ReadLine());
        float varX = 0;
        float varY = 0;

        Console.WriteLine("Введите координаты X и Y (не равные 0) через пробел");
        string[] coordinates = Console.ReadLine().Split(' ');

        // if (coordinates is not null)
        // {
        //     varX = Convert.ToInt32(coordinates[0]);
        //     varY = Convert.ToInt32(coordinates[1]);
        // }

        varX = Convert.ToInt32(coordinates[0]);
        varY = Convert.ToInt32(coordinates[1]);


        if (varX == 0 || varY == 0)
        {
            Console.WriteLine("Нарушено условие: Х и Y ≠ 0");
        }
        else if (varX > 0 && varY > 0)
        {
            Console.WriteLine("Номер координатной четверти: I");
        }
        else if (varX < 0 && varY > 0)
        {
            Console.WriteLine("Номер координатной четверти: II");
        }
        else if (varX < 0 && varY < 0)
        {
            Console.WriteLine("Номер координатной четверти: III");
        }
        else
        {
            Console.WriteLine("Номер координатной четверти: IV");
        }

    }

}
