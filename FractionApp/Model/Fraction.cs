

namespace FractionApp.Model
{
    internal class Fraction
    {
        private int _numerator;
        private int _denominator;

        public Fraction(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }

        public Fraction() { }

        public int Numerator { get { return _numerator; } set { _numerator = value; } }
        public int Denominator { get { return _denominator; } set {
                if (value == 0) throw new ArgumentException("Denominator can not be zero");
                _denominator = value;
            }
        }
        public static Fraction operator +(Fraction a) => a;
        public static Fraction operator -(Fraction a) => new(-a.Numerator, a.Denominator);
        public static Fraction operator +(Fraction a ,Fraction b) =>new(a.Numerator * b.Denominator 
                                        + a.Denominator * b.Numerator ,a.Denominator*b.Denominator);
        public static Fraction operator -(Fraction a, Fraction b) => a + (-b);
        public static Fraction operator *(Fraction a, Fraction b) => new(a.Numerator * b.Numerator, a.Denominator * b.Denominator);

        public static Fraction operator /(Fraction a, Fraction b)
        {
            try
            {
                if (b.Numerator == 0) throw new DivideByZeroException();
                return a * new Fraction(b.Denominator, b.Numerator);
            }
            catch (DivideByZeroException e)
            {
                Console.Error.WriteLine("Error:" + e.Message);
                return null;
                throw;
            }
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Fraction) return false;
            Fraction other = (Fraction)obj;
            return Numerator == other.Numerator && Denominator == other.Denominator;


        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Numerator, Denominator);
        }

        public override string? ToString()
        {
            return $"{Numerator}/ {Denominator}";
        }
    }
}
