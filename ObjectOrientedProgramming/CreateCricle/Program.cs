using System;

namespace CreateCricle
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(4, 5);
            Point p2 = new Point(8, 9);
            double distance = p1.DistanceTo(p2);
            Console.WriteLine("Distance: {0}" ,distance);
            Cricle c = new Cricle(p1, 5);
            Location location = c.GetLocationToPoint(p2);
            switch (location)
            {
                case Location.IN:
                    Console.WriteLine("Point p2 in cricle");
                    break;
                case Location.OUT:
                    Console.WriteLine("Point p2 out cricle");
                    break;
                case Location.ON:
                    Console.WriteLine("Point p2 on cricle");
                    break;

            }
            Console.ReadLine();
        }
    }
}
