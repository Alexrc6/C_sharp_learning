// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.

void PrintConsonantLetters(string str)
{
    string consonants = "bcdfghjklmnprstvwxz";

    if (str.Length == 0) return;

    if (consonants.Contains(str[0]))
        Console.Write($"{str[0]} ");

    // for (int i = 0; i < consonants.Length; i++)
    // {
    //     if (str[0] == consonants[i])
    //     {
    //         Console.Write($"{str[0]} ");
    //         break;
    //     }
    // }

    //PrintConsonantLetters(str.TrimStart(str[0]));
    PrintConsonantLetters(str[1..]); //значит - возьми все символы от 1, можно дополнить последним символом
    return;

}



Console.WriteLine("Enter string: ");
string str = Console.ReadLine()!;
PrintConsonantLetters(str);

//Console.WriteLine(str.TrimStart('a'));