// Дано N гирь с разным весом в случайном
// порядке. Определить вес самой тяжелой
// гири.

//int n = 5;
int[] array = new int[5]{5, 6, 9, 8, 11};
int i = 0;
int max = array[0];

while(i < array.Length)
{
        if (array[i] > max)
        {
                max = array[i];
        }
        i = i + 1;
}
Console.WriteLine($"{max} ");

max = array[0];
for(int j = 0; j < nameof; j++)