// Считать строку с консоли, состоящую из латинских букв в нижнем регистре. 
// Выяснить, сколько среди введённых букв гласных (aouei).
using System;
using System.Text;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;


int CountVowels(string str)
{
string vowels = "аеёийоуыэюяАЕЁИЙОУЫЭЮЯ";
//char[] vowels = {'а'};
int count = 0;
for (int i = 0; i < str.Length; i++)
{
    for (int j = 0; j < vowels.Length; j++)
    {
        if (str[i] == vowels[j])
        {
            count++;
            break;
        }
    }
}
return count;
}


string str = Console.ReadLine()!;

Console.WriteLine(CountVowels(str));




//Злата
// Считать строку с консоли, состоящую из латинских букв в нижнем регистре. 
// Выяснить, сколько среди введённых букв гласных (aouei).

// using System;
// using System.Text;
// Console.InputEncoding = Encoding.Unicode;
// Console.OutputEncoding = Encoding.Unicode;

// int FindVowels(string str)
// {
//     string vowels = "aoueiуеаояиыюэAOUEIУЕЫАОЭЯИЮ";
//     int count = 0;
//     for (int i = 0; i < str.Length; i++)
//     { 
//        for (int j = 0; j < vowels.Length; j++) 
//        {
//         if (str[i] == vowels[j])
//         {
//             count++;
//         }
//        }
//     }
//     return count;
// }

// Console.Write("Введите строку: ");
// string n = Console.ReadLine()!;
// int res = FindVowels(n);
// Console.WriteLine(res);










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




// string readString = Console.ReadLine()!;
// Console.WriteLine(VowelsCounter(readString.ToLower()));

// int VowelsCounter(string str)
// {
//     char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'y', 'u', 'а', 'е', 'и', 'ю', 'я', 'о'};
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

// string readString = Console.ReadLine()!;
// Console.WriteLine(VowelsCounter(readString.ToLower()));