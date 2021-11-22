using System;
using System.Collections.Generic;
using System.Text;

namespace CreatePoint
{
    public class Point2
    {
        public float Ax { get; set; }
        public float Ay { get; set; }
        public float Bx { get; set; }
        public float By { get; set; }
        public Point2()
        {

        }
        public double TinhKhoangCach()
        {
            float a = (Bx - Ax) * (Bx - Ax);
            float b = (By - Ay) * (By - Ay);
            float khoangCachAB = (float)Math.Sqrt(a + b);
            return khoangCachAB;

        }





    }
}
