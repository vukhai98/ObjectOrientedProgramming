using System;

namespace CreatClassPhanSo
{
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo ps1 = new PhanSo(2,5);
            //ps1.tuSo = 2;
            //ps1.mauSo = 5;
            float a = ps1.CreatePhanSo();
            //Console.WriteLine(ps1.CreatePhanSo());
            //Console.ReadKey();
            PhanSo ps2 = new PhanSo();
            ps2.tuSo = 1;
            ps2.mauSo = 2;
            float b = ps2.CreatePhanSo();
            Console.WriteLine("{0} + {1} = {2}", a, b,a+b);

        }
    }
}
