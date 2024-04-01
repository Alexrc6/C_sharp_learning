string str = Console.ReadLine();

char[] vowels = { 'а', 'е', 'ё', 'и', 'й', 'о', 'у', 'э', 'ю', 'я' };
//char[] vowels = {'а'};
int count = 0;
for (int i = 0; i < str.Length; i++)
{
    for (int j = 0; j < vowels.Length; j++)
    {
        if (str[i] == vowels[i])
        {
            count++;
        }
    }
}
Console.WriteLine(count);


//string str = Console.ReadLine();
//Console.WriteLine(str);

// string str = "as df";
// Console.WriteLine(str);

// //char[] CharMas = str.ToCharArray();

// char[] CharMas = new char[str.Length];
// for (int i = 0; i < str.Length; i++)
// {
//     CharMas[i] = str[i];
// }
// Console.WriteLine(CharMas);

// Console.WriteLine("Enter N - length of the array");
// int n = Convert.ToInt32(Console.ReadLine());
// char[] letters = new char[n];
// for (int i = 0; i < n; i++)
// {
//     Console.WriteLine("Enter symbol of array");
//     letters[i] = Convert.ToChar(Convert.ToString(Console.ReadLine()));
// }
// Console.WriteLine();
// Console.Write(letters);

// // string str = new string(letters);
// // Console.WriteLine();
// // Console.Write(str);

// string str = "";
// for (int i = 0; i < n; i++)
// {
//     //str += letters[i];
//     str = string.Concat(str,letters[i], " ");
// }
// Console.WriteLine();
// Console.Write(str);


// string s1 = "Hello, world, Helloworld, elloworld";
// string[] s4 = {"Hello", "world", "Helloworld", "helloworld"};
// string s5 = "!!!";
// string s6 = "world";
// char[] charArray = {'a', 'b', 'c'};
// string s2 = new string(charArray);

// string s3 = new string('a', 6);

// s1 = s1.Insert(6, s5);
// s1 = s1.Replace("o,", "o");
// string concatS = s1 + ", " + s6;
// concatS = concatS.Replace("!!! world, Helloworld, elloworld", " ");
// //concatS = concatS.Insert(11, s5);
// string s7 = string.Concat(concatS,"!!!");
// s7 = s7.Replace(" ,", ",");
// Console.WriteLine($"{s7}");


//Console.WriteLine($"{s1}, {s2}, {s3}");

// Console.WriteLine(s1.Contains("hello"));

// if(s4[0].EndsWith("lo"))
//     Console.WriteLine("OK");

//     Console.WriteLine(charArray.IndexOf("c"));