// Задача 2: Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт 
// номер координатной четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координату точки X (Х ≠ 0)");
Double varX = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату точки Y (Y ≠ 0)");
Double varY = Convert.ToDouble(Console.ReadLine());

if (varX == 0 || varY == 0)
{
    Console.WriteLine("Нарушено условие: Х и Y ≠ 0");
}
else
{
    if (varX > 0 && varY > 0)
    {
        Console.WriteLine("Номер координатной четверти: I");
    }
    if (varX < 0 && varY > 0)
    {
        Console.WriteLine("Номер координатной четверти: II");
    }
    if (varX < 0 && varY < 0)
    {
        Console.WriteLine("Номер координатной четверти: III");
    }
    if (varX > 0 && varY < 0)
    {
        Console.WriteLine("Номер координатной четверти: IV");
    }
}