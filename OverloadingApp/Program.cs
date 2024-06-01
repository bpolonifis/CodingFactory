namespace OverloadingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result1 = Add(1, 2, 3);
            int result2 =Add(1, 2, 3, 4, 5, 6);

            Console.WriteLine(result1);
            Console.WriteLine(result2);


            DateTime dt1 = GetDateTime();   //epoch
            DateTime dt2 = GetDateTime( year:2023,month:9,day:13);

            Console.WriteLine($"{dt1:F}");
            Console.WriteLine(dt2);


            double mul2 = Mul(10, 10.7D);
            double mul1 = Mul(5.0F, 2.8D);

            Console.WriteLine($"{0:N2} , {1:N2}", mul1 ,mul2);
            Console.WriteLine($"{mul1}");
            Console.WriteLine($"{mul2}");


        }

        public static int Add(params int[] nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            return sum;
        }

        public static DateTime GetDateTime(int year=1970, int month=1,int day=1,int hour=0, int min=0,int sec=0,int milli=0) //1/1/1970 = Epoc apo ekei metrane ta systymata Linux Unix
        {
            return new DateTime(year, month, day, hour, min, sec,milli, DateTimeKind.Utc);
        }

        //Overload metraei to deksia kommati
        public static double Mul(int a, double b)
        {
            return a * b;
        }
        public static int Mul(int a, int b)
        {
            return a * b;
        }

        public static double Mul(float a, double b)
        {
            return a * b;
        }


    }
}