namespace TwoDimArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 4];
            int[,] arr2 =
            {
                { 1, 2 },
                { 3, 5 },
                { 7, 9 }
            };

            for (int i = 0; i < arr.GetLength(0); i++)
            { 
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($" {arr2[ i , j]} ");
                }
                Console.WriteLine();
            }

            //jagged arrays
            int[][] arr3 = new int[3][];
            arr3[0] = new int[10];
            arr3[1] = new int[5];
            arr3[2] = new int[6];

            foreach (int[] row in arr3)
            {
                foreach (int el in row)
                {
                    Console.Write(el + " ");
                }
                Console.WriteLine();
            }


        }
    }
}