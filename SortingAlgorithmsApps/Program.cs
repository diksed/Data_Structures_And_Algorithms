var arr = new int[] { 40, 50, 10, 30, 20 };
PrintArray(arr);
SortingAlgorithms.SelectionSort.Sort(arr);
PrintArray(arr);


static void PrintArray<T>(T[] arr)
{
    Console.WriteLine();
    foreach (var item in arr)
    {
        Console.Write($"{item,-5}");
    }
    Console.WriteLine();
}
static void BubbleSortSample()
{
    var arr = new int[] { 40, 50, 10, 30, 20 };
    PrintArray(arr);
    SortingAlgorithms.BubbleSort.Sort(arr);
    PrintArray(arr);
}