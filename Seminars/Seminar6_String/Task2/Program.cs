// На основе символов строки (тип string) сформировать массив символов (тип char[]). Вывести массив на экран.
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

using System;
using System.Text; //эта и последующие 2 строчки позволяют работать с русским
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

char[] StringToChar(string str)
{
char[] symbols = new char[str.Length];
for (int i = 0; i < str.Length; i++)
{
    symbols[i] = str[i];
}
return symbols;
}

void PrintMass(char[] collection)
{
    foreach (char item in collection)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

string str1 = Console.ReadLine();
char[] str2 = StringToChar(str1);
PrintMass(str2);






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