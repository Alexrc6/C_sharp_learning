// Дано натуральное трёхзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд числа должен располагаться на 0-
// м индексе массива, старший – на 2-м. 

void PrintMas(int[] col)
{
    foreach (int item in col)
    {
        Console.Write($"{item}");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите трехзначное число");

int n = 3;
int num = Convert.ToInt32(Console.ReadLine());

int[] mas = new int[n];

for (int i = 0; i < n; i++)
{
    int digital = num % 10;
    mas[i] = digital;

    num = num / 10;
    //Console.Write($"{digital} ");
}



PrintMas(mas);





// Артем
// string num = Console.ReadLine();

// int[] list = new int[num.Length];
// int[] listReverse = new int[num.Length];

// for (int i = 0; i < num.Length; i++)
// {
    
//     char n = num[i];
//     list[i] = Convert.ToInt16(Convert.ToString(n));
//     listReverse[i] = Convert.ToInt16(Convert.ToString(num[num.Length - i - 1]));
//     Console.WriteLine(n);
// }

// Console.WriteLine();



// Марина
// / int[] arr = { }
// // int n = Convert.ToInt32(Console.ReadLine());

// string n = Console.ReadLine();
// int len = n.Length;

// int[] arr = new int[len];
//  for ( int i = 0; i < len; i++)
//  {
//     arr[i] = Convert.ToInt32(Convert.ToString(n[i])); 
//  }

// void PrintMas(int[] col)
// {
//     foreach (int item in col)
//     {
//         Console.Write($"{item} ");
//     }
//     Console.WriteLine();
// }

// PrintMas(arr);

// int[] arr2 = new int[len];

// for ( int i = 0; i < len; i++)
//  {
//     arr2[i] = Convert.ToInt32(Convert.ToString(n[len - 1 - i])); 
//  }
 
//  PrintMas(arr2);