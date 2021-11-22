using System;

namespace CreatePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            //double khoangCachAB;
            Point pointA= new Point(3, 1);
            Point pointB = new Point(2, 4);
            //double a = (pointB.Ox - pointA.Ox) * (pointB.Ox - pointA.Ox);
            //double b = (pointB.Oy-pointA.Oy) * (pointB.Oy - pointA.Oy);
            //khoangCachAB = Math.Sqrt( a + b);
            double khoangCachAB = TinhKhoangCach(pointA,pointB);
            Console.WriteLine("Khang cach giua A va B la {0}", khoangCachAB);
            Point2 point = new Point2();
            point.Ax = 2;
            point.Ay = 3;
            point.By = 4;
            point.Bx = 5;
            Console.WriteLine(point.TinhKhoangCach());
            Console.ReadKey();

        }
        public static double TinhKhoangCach(Point pointA, Point pointB)
        {
            double a = (pointB.Ox - pointA.Ox) * (pointB.Ox - pointA.Ox);
            double b = (pointB.Oy - pointA.Oy) * (pointB.Oy - pointA.Oy);
            double khoangCachAB = Math.Sqrt(a + b);
            return khoangCachAB;
            
        }
    }
}
