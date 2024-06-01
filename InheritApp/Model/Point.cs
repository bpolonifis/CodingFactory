

namespace InheritApp.Model
{
    internal  class Point
    {
        public int X { get; set; }

        // static factories
        public static Point GetPoint()
        {
            return new Point();
        }


        //Virtual == Overridable
        protected virtual void Move5()
        {
            X += 5; 
        }


        public override string ToString()
        {
            return $"{{X={X}}}";
        }
    }
}
