void PrintSquaresAllNumbersinRow(int Num)
{
    int i = 1;
    while (i <= Num)
    {
        Console.Write($"{i * i} ");
        i++;
    }
}

PrintSquaresAllNumbersinRow(5);
Console.WriteLine();
PrintSquaresAllNumbersinRow(10);
Console.WriteLine();
PrintSquaresAllNumbersinRow(15);
