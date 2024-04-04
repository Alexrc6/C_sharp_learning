
// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

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

void PrintString(string str)
{
    for (int i = 0; i < str.Length; i++)
    {
        Console.Write("{0} ", str[i]);
    }
}

string stringOfLetters = "";
stringOfLetters = CreateRandomString(11);
PrintString(stringOfLetters);
Console.WriteLine();
string s = stringOfLetters.ToLower();
PrintString(s);