namespace SymmetricArrayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 , 2, 1 };
            bool isSymmetric = true;

                for (int i = 0, j = arr.Length + 1; i < j;i++,j--)
                {
                    if (arr[i] != arr[j])
                    {
                    isSymmetric = false;
                    break;
                    }
                }
            Console.WriteLine($"Array is symmetric:{isSymmetric}");

        }
    }
}