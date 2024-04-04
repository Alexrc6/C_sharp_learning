// Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

using System;
using System.Text;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

char[,] CreateRandomArrayOfChar(int ArrayRows, int ArrayColums)
{
   char[,] SymbolsArr = new char[ArrayRows, ArrayColums];
   Random rnd = new Random();
   for (int i = 0; i < SymbolsArr.GetLength(0); i++)
   {
      for (int j = 0; j < SymbolsArr.GetLength(1); j++)
      {
         SymbolsArr[i, j] = Convert.ToChar(rnd.Next('A', 'z' + 1));
      }
   }
   return SymbolsArr;
}

string ConvertArrayToString(char[,] array2D)
{
   string stringNew = "";
   for (int i = 0; i < array2D.GetLength(0); i++)
   {
      for (int j = 0; j < array2D.GetLength(1); j++)
      {
         stringNew += array2D[i, j];
      }
   }
   return stringNew;
}

void PrintArr(char[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         Console.Write("{0} ", array[i, j]);
      }
      Console.WriteLine();
   }
}

void PrintString(string str)
{
   for (int i = 0; i < str.Length; i++)
   {
      Console.Write("{0} ", str[i]);
   }
}

char[,] ArrOfSymbols = CreateRandomArrayOfChar(3, 4);

PrintArr(ArrOfSymbols);
Console.WriteLine();
PrintString(ConvertArrayToString(ArrOfSymbols));




// Console.WriteLine();
// char f = 'A';
// for (int i = 0; i < 206; i++)
//     {
//        Console.Write(f);
//        f = Convert.ToChar(f + 1);
//        Console.Write(' ');
//     }