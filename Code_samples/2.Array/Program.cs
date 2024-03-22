// Array input and output. Option №1
Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[n];
//double[] mas = new double[n];
//string[] mas = new string[n]; //выводятся пустые строки

int ind = 0;
while (ind < mas.Length)
{
    Console.Write($"{mas[ind]} ");
    ind++;
}

Console.WriteLine();

//Array output. For
for (int i = 0; i < mas.Length; i++)
{
    Console.Write($"{mas[i]} ");
}

Console.WriteLine();

//Array output. Foreach
foreach (int item in mas)
{
    Console.Write($"{item} ");
}

Console.WriteLine();

//Array output. Function
void PrintMas(int[] col) //void - the data type that the function will return. May be another type
                         //int[] col - type and name of input data 
{
    foreach (int item in col)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

PrintMas(mas);

Console.WriteLine();

//function for specifaying array with random elements
int[] RandomMas(int[] col) //int[] - the data type (array) that the function will return.
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(0, 10);
    }

    return col;
}

int[] new_mas = RandomMas(mas); //new_mas - array that we will send to the function 
//var new_mas = RandomMas(mas); // function call option. var - determines the data type independently
PrintMas(new_mas); new_mas

var len = 6;

var lst = Append(len);

int index = 0;




//function with two variables
string S(int[] col, int m)
{
    foreach (var item in col)
    {
        if (item == m) return "Да"; //Only the first call of RETURN will be executed
    }
    return "Нет";
}

Console.WriteLine(S(new_mas, m)); new_mas