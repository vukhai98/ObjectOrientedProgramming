using System;
using System.Collections.Generic;
using System.Text;

namespace CreateCricle
{
    class Cricle
    {
        public Point center { get; set; }
        public double radius { get; set; }
        public Cricle ()
        {
            center = new Point();
        }
        public  Cricle (Point point, double _raduis)
        {
            center = point;
            radius = _raduis;
        }
        public void Input()
        {
            // nhập tâm 
            Console.WriteLine("Center:");
            center.Input();
            // nhập bán kính
            Console.WriteLine("Radius:");
            radius = Convert.ToDouble(Console.ReadLine());
        }
        public Location GetLocationToPoint(Point point)
        {
            double distance = center.DistanceTo(point);
            if (distance == radius)
            {
                return Location.ON;
            }
            else if (distance > radius)
            {
                return Location.OUT;
            }
            else
            {
               return   Location.IN;
            }

        }
    }
}
