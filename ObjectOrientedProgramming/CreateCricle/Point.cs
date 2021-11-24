using System;
using System.Collections.Generic;
using System.Text;

namespace CreateCricle
{
    class Point
    {
        public int oX { get; set; }
        public int oY { get; set; }
        public Point ()
        {

        }
        public Point(int x, int y)
        {
            oX = x;
            oY = y;
        }
        public double DistanceTo(Point another)
        {
            return Math.Sqrt(
                Math.Pow(oX - another.oX, 2) + Math.Pow(oY - another.oY, 2)
                );
        }
        public void Input()
        {
            Console.WriteLine("Ox: ");
            oX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Oy: ");
            oY = Convert.ToInt32(Console.ReadLine());
        }
    }
}
