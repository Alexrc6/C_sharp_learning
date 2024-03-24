void Increment(ref int n)
{
    n++;
    Console.WriteLine($"Число в методе Increment: {n}");
}
 
int number = 5;
Console.WriteLine($"Число до метода Increment: {number}");
Increment(ref number);
Console.WriteLine($"Число после метода Increment: {number}");



// void Increment(ref readonly int n)
// {
//     // n++; // нельзя, иначе будет очишка компиляции
//     Console.WriteLine($"Число в методе Increment: {n}");
// }
  
// int number = 5;
// Increment(ref number);
// Console.WriteLine($"Число после метода Increment: {number}");