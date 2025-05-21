namespace SelectionSort
{
  internal class Program
  {
    static void SelectionSort(int[] arr)
    {
      int n = arr.Length;

      for (int i = 0; i < n - 1; i++)
      {
        int minIndex = i;

        for (int j = i + 1; j < n; j++)
        {
          if (arr[j] < arr[minIndex])
          {
            minIndex = j;
          }
        }

        var tmp = arr[minIndex];
        arr[minIndex] = arr[i];
        arr[i] = tmp;
      }
    }

    // static void Main(string[] args)
    // {
    //   int[] arr = { 6, 2, 1, 8, 9, 3, 7 };
    //   SelectionSort(arr);

    //   foreach (int num in arr) {
    //     Console.Write(num + " ");
    //   }
    // }  
  }
}