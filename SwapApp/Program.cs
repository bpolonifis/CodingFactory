namespace SwapApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y =10;
            Swap1(ref x,ref y);
            Console.WriteLine($"x:{x},y: {y}");

            string? s; //null
            ChangeStr( out s );
            Console.WriteLine(s);


        }

        //Lathos tropoi
        //public static void Swap1(int x, int y)
        //{
        //    int tmp = x;
        //    x = y;
        //    y = tmp;
        //}

        //public static void ChangeStr(string str)
        //{
        //    str = "CF AUEB";
        //}

        public static void Swap1( ref int x, ref  int y) //ref einai enas telestis poy metrapei ena value sthn diethynsi mnimis pou exei.
        {
            //int tmp = x;
            //x = y;
            //y = tmp;

            (x, y) = (y, x);//toupils pleiada
        }

        public static void ChangeStr(out string str) //ref me null = null
        {
            str = "CF AUEB";
        }

    }
}