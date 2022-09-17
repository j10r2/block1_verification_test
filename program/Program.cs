string[] array = new string[new Random().Next(10, 20)];
void FillArray(string[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = Convert.ToString(new Random().Next(0, 10000) / new Random().Next(1, 10));
    }
}
FillArray(array);
void PrintArray(string[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write(arr[i]);
        if (i < length - 1) Console.Write(", ");
    }
    Console.WriteLine();
}
string[] SelectItemsByLength(string[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) counter++;
    }
    if (counter == 0)
    {
        string[] arr1 = { "no matching items in massive" };
        return arr1;
    }
    else
    {
        string[] arr1 = new string[counter];
        int j = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                arr1[j] = arr[i];
                j++;
                if (j == arr1.Length) break;
            }
        }
        return arr1;
    }
}
Console.Clear();
Console.WriteLine("Input massive");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Resulting massive:");
PrintArray(SelectItemsByLength(array));
Console.WriteLine();