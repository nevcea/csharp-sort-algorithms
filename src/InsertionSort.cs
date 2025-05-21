namespace InsertionSort
{
  internal class Program
  {

    public static int[] InsertionSort(int[] arr)
    {
      for (int i = 1; i < arr.Length; i++)
      {
        for (int j = i; 0 < j; j--)
        {
          if (arr[j] < arr[j - 1])
          {
            var tmp = arr[j];
            arr[j] = arr[j - 1];
            arr[j - 1] = tmp;
          }
        }
      }

      return arr;
    }

    // static void Main(string[] args)
    // {
    //   int[] arr = { 6, 2, 1, 8, 9, 3, 7 };
    //   InsertionSort(arr);

    //   foreach (int num in arr) {
    //     Console.Write(num + " ");
    //   }
    // }
  }
}