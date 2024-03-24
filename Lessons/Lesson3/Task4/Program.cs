void FillArray(int[] arr)
{
for(int i = 0; i < arr.Length; i++)
{
   arr[i] = new Random().Next(1, 5); 
}
}

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write($"{item} ");
    }
}

int GetSumOfElements(int[] arr)
{
    int sum = 0;
    foreach (int item in arr)
    {
      sum = sum + item;  
    }
    return sum;
}

int GetProductOfElements(int[] arr)
{
    int product = 1;
    foreach (int item in arr)
    {
        product = product * item;
    }
    return product;
}

int n = 10;
int[] arr = new int [n];
FillArray(arr);
PrintArray(arr);
int sum = GetSumOfElements(arr);
int product = GetProductOfElements(arr);
Console.WriteLine();
Console.WriteLine(sum);
Console.WriteLine(product);