// Домашнее задание
// Лекция 4. Двумерные массивы
// Считать с консоли строку, состоящую из цифр и латинских букв. Сформировать массив, состоящий
// из цифр этой строки.
// Пример
// abc123def06g => [1, 2, 3, 0, 6]
// Рекомендации
// • Разделить логику алгоритма на функции
// • Память под массив выделять необходимого размера (не больше, чем количество элементов)



int[] CreateNumMasFromString(string strNumAndLetters)
{
    string numbers = "";
    foreach (char e in strNumAndLetters)
    {
        if (char.IsAsciiLetter(e) == false)
        {
            numbers += e;
        }
    }

    int[] masNum = new int[numbers.Length];

    for (int i = 0; i < masNum.Length; i++)
    {
        masNum[i] = Convert.ToInt32(Convert.ToString(numbers[i]));
    }
    return masNum;
    //return numbers;
}

void PrintStr(string str)
{
    Console.Write("Строка: ");
    for (int i = 0; i < str.Length; i++)
    {
        Console.Write($"{str[i]} ");
    }
}

void PrintMas(int[] mas)
{
    Console.Write("Получен массив чисел: ");
    for (int i = 0; i < mas.Length; i++)
    {
        Console.Write($"{mas[i]} ");
    }
}


Console.WriteLine("Введите строку, состоящую из цифр и латинских букв");
string str = Console.ReadLine();
int[] newMasNum = CreateNumMasFromString(str);
PrintStr(str);
PrintMas(newMasNum);
//PrintStr(CreateNumMasFromString(str));
