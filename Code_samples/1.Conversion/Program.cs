//1
Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[n];


//2
string n = Console.ReadLine();
int len = n.Length;
int[] arr = new int[len];
 for ( int i = 0; i < len; i++)
 {
    arr[i] = Convert.ToInt32(Convert.ToString(n[i])); // will output int-type values
    //arr[i] = Convert.ToInt32(n[i]); // will output char-type values
 }

