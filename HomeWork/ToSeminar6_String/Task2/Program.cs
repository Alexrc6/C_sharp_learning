// На основе символов строки (тип string) сформировать массив символов (тип char[]). Вывести массив на экран.
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

using System;
using System.Text; //эта и последующие 2 строчки позволяют работать с русским
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

char[] StringToChar(string str)
{
char[] symbols = new char[str.Length];
for (int i = 0; i < string.Length; i++)
{
    symbols[i] = str[i];
}
return symbols;
}

void PrintMass(char[] collection)
{
    foreach (var item in collection)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

string str1 = Console.ReadLine();
char[] str2 = StringToChar(str1);
Console.WriteLine(PrintMass(str2));




// int VowelsCounter(string str)
// {
//     char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'y', 'u' };
//     int res = 0;
//     foreach (char c in str)
//     {
//         if (vowels.Contains(c))
//         {
//             res++;
//         }
//     }

//     return res;
// }




string readString = Console.ReadLine()!;
Console.WriteLine(VowelsCounter(readString.ToLower()));





// using System;
// using System.Text;
// Console.InputEncoding = Encoding.Unicode;
// Console.OutputEncoding = Encoding.Unicode;

//  void PrintMass(char[] collection)
// {
//     foreach (var item in collection)
//     {
//         Console.Write($"{item} ");
//     }
//     Console.WriteLine();
// }

 
 
// string n = Console.ReadLine();
// char[] mass=new char[n.Length];
// for(int i=0;i<n.Length;i++){

// mass[i]=n[i];


// }


// PrintMass(mass);