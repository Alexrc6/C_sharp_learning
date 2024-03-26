// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.


int[] FillArrWithRandomNum(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 101);
    }
    return array;
}

bool DeterminePrimeNum(int number)
{
    //Console.WriteLine(number);
    int count = 1;
    int Div = 3;
    Console.WriteLine(number);
    while (count < 2 || Div < number)
    {
        if (number % Div == 0) 
        {
           
            count = 2;

        }
        Div++;
    }

    if (count == 1)
    {
        Console.WriteLine("true");
        
        return true;
        
    }
    else
    {
        Console.WriteLine("false");
        count = 1;
        return false;
        
    }

}

int FindCountPrimeNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (DeterminePrimeNum(array[i]) == true)
        {
            count++;
            Console.Write($"{array[i]}");
        }

    }
    return count;
}

void PrintMas(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        Console.Write($"{mas[i]} ");
    }
}

int n = 10;

int[] arrRand = FillArrWithRandomNum(new int[n]);
PrintMas(arrRand);
Console.WriteLine();
int countNew = FindCountPrimeNum(arrRand);
Console.WriteLine(countNew);


