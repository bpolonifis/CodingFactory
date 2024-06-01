using InheritApp.Model;


namespace InheritApp
{
    internal class Program
    {
        static void Main(string[] args)

        {
            List<Point> points = new()
            {
                new Point { X=3},
                new Point2D { X=4, Y=6},
                new Point3D { X=5, Y=7, Z=7},
            };


            foreach (Point point in points)
            {
                Console.WriteLine(point);
            };




            Point p1 = new() { X = 3 };
            Point2D p2 = new() { X = 2, Y = 7 };
            Point3D p3 = new() { X = 4, Y = 1, Z = 4 };

            //Subtype polymorphism
            Point p4 = new Point2D()
            {
                X = 5,
                Y = 6
            };

            ((Point2D)p4).Y = 7;


            Console.WriteLine("p1 Initial position " + p1);

            p1.Move5();
            Console.WriteLine("p1 moved 5 units. New position" + p1);

            Console.WriteLine("p3 Initial position " + p3);

            p3.Move5();
            Console.WriteLine("p3 moved 5 units. New position" + p3);

            // Downcast to Point 2D
            Console.WriteLine("p4 Initial position " + p4);
            p4.Move5();
            Console.WriteLine("p4 moved 5 units. New position" + p4);

            DoMove5(p3);
            DoPrint(p4);

        }

        //Polymorphism
        public static void DoMove5(Point point)
        {
            point.Move5();
        }

        public static void DoPrint(Point point)
        {
            Console.WriteLine(point.ToString());
        }

    }
}