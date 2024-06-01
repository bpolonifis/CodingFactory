namespace DataTypesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"int\t{typeof(int)} \t {sizeof(int)*8} \t {int.MinValue} - {int.MaxValue} ");
            Console.WriteLine($"uint\t{typeof(uint)} \t {sizeof(uint) * 8} \t {uint.MinValue} - {uint.MaxValue} ");
            Console.WriteLine($"byte\t{typeof(byte)} \t {sizeof(byte) * 8} \t {byte.MinValue} - {byte.MaxValue} ");
            Console.WriteLine($"sbyte\t{typeof(sbyte)} \t {sizeof(sbyte) * 8} \t {sbyte.MinValue} - {sbyte.MaxValue} ");
            Console.WriteLine($"long\t{typeof(long)} \t {sizeof(long)} \t{long.MinValue} - {long.MaxValue}");
            Console.WriteLine($"ulong\t{typeof(ulong)} \t {sizeof(ulong) * 8} \t {ulong.MinValue} - {ulong.MaxValue} ");
            Console.WriteLine($"short\t{typeof(short)} \t {sizeof(short)} \t {short.MinValue} -{short.MaxValue}");
            Console.WriteLine($"ushort\t{typeof(ushort)} \t {sizeof(ushort)} \t {ushort.MinValue} -{ushort.MaxValue}");
            Console.WriteLine($"float \t{typeof(float)} \t {sizeof(float)} \t {float.MinValue} -{float.MaxValue}");
            Console.WriteLine($"double\t{typeof(double)} \t {sizeof(double)} \t {double.MinValue} -{double.MaxValue}");
            Console.WriteLine($"decimal\t{typeof(decimal)} \t {sizeof(decimal)} \t {decimal.MinValue} -{decimal.MaxValue}");
        }
    }
} 