using System;
using System.Collections.Generic;

namespace CreatePhanso
{
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo p1 = new PhanSo(3, 5);
            PhanSo p2 = new PhanSo(2, 4);
            PhanSo p3 = p1.Cong(p2);
            PhanSo p4 = p1.Tru(p2);
            PhanSo p5 = p1.Tich(p2);
            PhanSo p6 = p1.Thuong(p2);

            Console.WriteLine("{0} + {1} = {2} ", p1.Display(), p2.Display(), p3.Display());
            Console.WriteLine("{0} - {1} = {2} ", p1.Display(), p2.Display(), p4.Display());
            Console.WriteLine("{0} * {1} = {2} ", p1.Display(), p2.Display(), p5.Display());
            Console.WriteLine("{0} / {1} = {2} ", p1.Display(), p2.Display(), p6.Display());
            Console.ReadKey();


        }
    }
}
