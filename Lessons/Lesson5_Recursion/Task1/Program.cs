// void OM(int n)
// {
//     if (n == 1)
//     {
//         // Console.WriteLine($"Stop: {n}");
//         return;
//         // Console.WriteLine($"op: {n}");
//     }
    
//     OM (n - 1);
//     Console.WriteLine(n);
// }
// OM(5);


int Fact(int n)
{
    if (n == 1 || n == 0)
    {
        Console.WriteLine($"Stop: {n}");
        return 1;
        // Console.WriteLine($"op: {n}");
    }
    Console.WriteLine(n);
    int NF = n * Fact(n - 1);
    Console.WriteLine($"n = {n},  n! = {NF}");
    return NF;
    
}
Console.Write(Fact(5));



// Добавить в код отладочный вывод, который
// позволит увидеть «раскручивание» рекурсии, то
// есть процесс возвратов к местам рекурсивного
// вызова функции на строке 9.


