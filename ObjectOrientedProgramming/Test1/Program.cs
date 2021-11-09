using System;

namespace Test1
{

    class Program
    {
        class TestCsharpOne
        {
            public static void Main()
            {
                int i, n;
                int t = 2;
                int sum = 0;
                Console.WriteLine("********************************");
                Console.WriteLine("Chuong trinh tinh tong day so S = 2 + 6 + 10 +....+ n");
                Console.Write("Moi ban nhap so phan tu cua phuong trinh: ");
                n = int.Parse(Console.ReadLine());
                for ( i = 1; i <= n; i++)
                {
                    sum += t;
                    if(i<n)
                    {
                        Console.Write(" {0} +", t);
                    } 
                    else
                    {
                        Console.Write(" {0} \n ", t);
                    }
                    t = i* 4 + 2;
                }
                Console.WriteLine("Tong cua day so S co {0} phan tu la: {1}", n, sum);
                Console.ReadKey();

               
            }
        }
    }
}
