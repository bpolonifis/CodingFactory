using InheritApp.Model;


namespace InheritApp.Model
{
    internal class Point3D : Point2D
    {
        public int Z { get; set; }

        public  override void Move5()
        {
            base.Move5();
            Z += 5;
        }

        public override string ToString()
        {
            return base.ToString() + $"{{z={Z}}}";
        }
    }
}
