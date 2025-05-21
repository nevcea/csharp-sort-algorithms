namespace BubbleSort
{
  internal class Program
  {
    static void BubbleSort(int[] arr)
    {
      int n = arr.Length;

      for (int i = 0; i < n - 1; i++)
      {
        for (int j = 0; j < n - i - 1; j++)
        {
          if (arr[j] > arr[j + 1])
          {
            int tmp = arr[j];
            arr[j] = arr[j + 1];
            arr[j + 1] = tmp;
          }
        }
      }  
    }
 
    // static void Main(string[] args)
    // {
    //   int[] arr = { 6, 2, 1, 8, 9, 3, 7 };
    //   BubbleSort(arr);

    //   foreach (int num in arr) {
    //     Console.Write(num + " ");
    //   }
    // }   
  }
}