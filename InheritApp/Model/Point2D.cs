using InheritApp.Model;


namespace InheritApp.Model
{
    internal class Point2D : Point
    {
        public int Y { get; set; }

        /* public Point2D() : base() 
         {
             Y = 0;
         }*/

        public override  void Move5()
        {
            base.Move5();
            Y += 5;
        }

        public override string ToString()
        {
            return base.ToString() + $"{{y={Y}}}";
        }


    }
}
