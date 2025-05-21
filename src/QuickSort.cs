namespace QuickSort
{
  internal class Program
  {
    public static void QuickSort(int[] arr, int low, int high)
    {
      if (low < high)
      {
        int pivotIndex = Partition(arr, low, high);
        QuickSort(arr, low, pivotIndex - 1);
        QuickSort(arr, pivotIndex + 1, high);
      }      
    }

    public static int Partition(int[] arr, int low, int high)
    {
      int pivot = arr[high];
      int index = low - 1;

      for (int i = low; i < high; i++)
      {
        if (arr[i] <= pivot)
        {
          index++;
          Swap(arr, index, i);
        }
      }

      Swap(arr, index + 1, high);

      return index + 1;
    }

    static void Swap(int[] arr, int a, int b)
    {
      var tmp = arr[a];
      arr[a] = arr[b];
      arr[b] = tmp;
    }

    // static void Main(string[] args)
    // {
    //   int[] arr = { 6, 2, 1, 8, 9, 3, 7 };
    //   QuickSort(arr, 0, arr.Length - 1);

    //   foreach (int num in arr) {
    //     Console.Write(num + " ");
    //   }
    // }  
  }
}