//Задайте массив символов (тип char []). Создайте строку из символов этого массива.

string CharToString(char[] arr)
{
    string st = "";
    foreach (var item in arr)
    {
        st += item;
    }
    return st;
}


char[] chars = new char[] {'a', 'b', '1', 'd'};
Console.WriteLine(CharToString(chars));




// Задайте массив символов (тип char []). Создайте строку из символов этого массива. 
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”
// string CharsOfString(char[] arr)
// {
//     string st = "";
//     for (int i = 0; i < arr.Length; i++)
//     {
//         st += arr[i];
//     }
//     return st;
// }

// string CharsOfString2(char[] arr)
// {
//     string st = "";
//     foreach (var i in arr)
//     {
//         st += i;
//     }
//     return st;
// }


// char[] chars = new char[] {'a', '1', 'c', 'd', 'z'};
// //string st = CharsOfString(chars);
// Console.WriteLine(CharsOfString(chars));
// Console.WriteLine(CharsOfString2(chars));

// // string st2 = "12345";
// // for (int i = 0; i < st2.Length; i++)
// // {
// //     Console.WriteLine(st2[i]);
// // }
