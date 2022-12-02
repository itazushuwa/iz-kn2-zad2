Console.OutputEncoding = System.Text.Encoding.UTF8;
Random rnd = new Random(DateTime.Now.Millisecond);
Console.WriteLine("Размер массива:");
int[] arr = new int[int.Parse(Console.ReadLine())];
int min = 0, max = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(-101, 100);
    Console.Write(arr[i] + ", ");
    if (arr[i] >= arr[max]) max = i;
    if (arr[i] <= arr[min]) min = i;
}
Console.WriteLine();
int swap = arr[min];
arr[min] = arr[max];
arr[max] = swap;
foreach (var c in arr)
{
    Console.Write(c + ", ");
}
