using System;

namespace Test1
{

    class Program
    {
        class TestCsharpOne
        {
            public static void Main()
            {
                int n = 0;
                int t = 2;
                int sum = 0;
                bool flag = true;
                Console.WriteLine("********************************");
                Console.WriteLine("Chuong trinh tinh tong day so S = 2 + 6 + 10 +....+ n");
                Console.Write("Moi ban nhap so phan tu cua phuong trinh: ");
                // dat 1 cai co dung vong while
                // nhap dung : flag = false
                // nhap sai : yeu cau nhap lai
                while (flag)
                {
                    #region 
                    //string input = Console.ReadLine();
                    //if (int.TryParse(input, out n))
                    //{
                    //    for (int i = 1; i <= n; i++)
                    //    {
                    //        sum += t;
                    //        if (i < n)
                    //        {
                    //            Console.Write(" {0} +", t);
                    //        }
                    //        else
                    //        {
                    //            Console.Write(" {0} \n ", t);
                    //        }
                    //        t = i * 4 + 2;
                    //    }
                    //    Console.WriteLine("Tong cua day so S co {0} phan tu la: {1}", n, sum);
                    //    flag = false;
                    //    // clear data
                    //    // 
                    //    //i = n = sum = 0;
                    //    //input = string.Empty;

                    //}
                    //else
                    //{
                    //    Console.WriteLine("sai nhap lai");
                    //}
                    #endregion
                    flag = Helper.SumCustom(n, sum, t); // c2
                }

                Console.ReadKey();
            }

           




        }
    }
}
