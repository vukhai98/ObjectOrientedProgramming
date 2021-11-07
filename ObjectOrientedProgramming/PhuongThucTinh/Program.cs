using System;

namespace PhuongThucTinh
{
    class TienIch
    {
        public static long LuyThua(int CoSo, int SoMu)
        {
            long KetQua = 1;
            for (int i = 0; i < SoMu ; i++)
            {
                KetQua *= CoSo;
            }
            return KetQua;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TienIch.LuyThua(3,3));
            Console.ReadKey();
        }
    }
}
