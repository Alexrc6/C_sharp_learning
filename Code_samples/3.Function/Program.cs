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
PrintMas(new_mas); new_mas


//function with two variables. Determining the amount of a certain digit in an array
string S(int[] col, int m)
{
    foreach (var item in col)
    {
        if (item == m) return "Да"; //Only the first call of RETURN will be executed
    }
    return "Нет";
}

Console.WriteLine(S(new_mas, m)); 