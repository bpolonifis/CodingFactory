namespace SelectionSortApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, -1, 10, 11, 0 };
            int min;
            int minPosition=0;
            int tmp;
            for (int i = 0; i < arr.Length - 1; i++)
                {
                    min =int.MaxValue;

                    for (int j = i;j<arr.Length; j++)
                    {
                        //Find min Value of Subarray
                        if (arr[j] < min)
                        {
                            min = arr[j];
                            minPosition = j;
                        }

                        //Swap
                        tmp = arr[j];
                        arr[j] = arr[minPosition];
                        arr[minPosition] = tmp;
                    
                    }


                }
            foreach (int item in arr)
                {
                    Console.WriteLine(item + " ");
                }
        }
    }
}