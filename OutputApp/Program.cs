namespace OutputApp
{
    /// <summary>
    /// Output syntax types in C#.
    /// 1.Concat
    /// 2.Place Holders
    /// 3.Interpolation
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            Console.WriteLine("Num= " + num); //con cut metatrepetai automata to num se string giati exei +, pera apo auto pali string thaginotan giati einia mesa sto WriteLine
            Console.WriteLine("Num= {0} ,Num*2={1}", num,num*2);//) {0} antistoixei sthn prwti parametro meta to komma, {1} sthn deyteri parametro klp
            Console.WriteLine($"Num= {num}");// interpolation ginetai interprinted san metavliti
        }
    }
}