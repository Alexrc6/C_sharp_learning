// Задача 3: Задайте произвольную строку. 
// Выясните, является ли она палиндромом.

using System;
using System.Text;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

string CreateRandomString(int n)
{
    string str = "";
    int num = 0;
    Random rnd = new Random();

    for (int i = 0; i < n; i++)
    {
        num = rnd.Next(1, 3);
        if (num == 1)
        {
            char sym = Convert.ToChar(rnd.Next('A', 'Z'));
            str += sym;
            // Console.Write($"-{sym}-");
        }
        else
        {
            char sym = Convert.ToChar(rnd.Next('a', 'z'));
            str += sym;
            // Console.Write($"-{sym}-");
        }
    }
    return str;
}

bool CheckForPalinndrome(string str)
{

    for (int i = 0; i < str.Length / 2; i++)
    {
        if (str[i] != str[str.Length - i - 1])
        {
            return false;
        }
    }
    return true;
}

void PrintString(string str)
{
    for (int i = 0; i < str.Length; i++)
    {
        Console.Write("{0} ", str[i]);
    }
}

string stringOfLetters = "";
stringOfLetters = CreateRandomString(11);
//stringOfLetters = "!sГf1h1fГs!";
PrintString(stringOfLetters);
Console.WriteLine();
if (CheckForPalinndrome(stringOfLetters) == true)
{
    Console.WriteLine("Строка является палиндромом.");
}
else
{
    Console.WriteLine("Строка не является палиндромом.");
}





// public class Task3
// {
// public static void Main(string[] args)
// {
// // Входная строка для проверки
// string input = "шалаш";
// // Вызов метода для проверки, является ли строка палиндромомbool isPalindrome = IsPalindrome(input);
// // Вывод результата
// Console.WriteLine(isPalindrome ? "Да" : "Нет");
// }
// // Метод для проверки, является ли строка палиндромомpublic static bool IsPalindrome(string str)
// {
// // Нормализация строки путем удаления не буквенно-цифровыхсимволов и приведения к нижнему регистру
// string normalized = new
// string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
// // Сравнение строки с ее перевернутым вариантом
// return normalized.SequenceEqual(normalized.Reverse());
// }
// }