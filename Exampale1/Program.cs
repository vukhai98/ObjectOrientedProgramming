using System;

namespace Exampale1
{
    class Program
    {
        //1.input
        //2.output
        //3.cách giải
        //  + chia bài toán thành các bài toán nhỏ
        //  + các case (exception)

        //một số có phải là số nguyên tố hay không 
        // In các số nguyên tố trong một phạm vi nhất định
        static void Main(string[] args)
        {
            // nhận data từ bàn phím
            Console.WriteLine("Chuong trinh xac dinh so nguyen to ");

            int t = 0; 
            Console.Write("Moi ban nhap 1 so bat ky :");
            string n = Console.ReadLine();
            // check data từ bàn phím
            if (int.TryParse(n,out t))
            {
                if (LaSoNguyenTo(t))
                {
                    Console.WriteLine("So ban nhap {0} la so nguyen to", t);
                }
                else
                {
                    Console.WriteLine("So ban nhap {0} khong phai la so nguyen to", t);
                }

                int sum = 0;
                // lấy số từ 2-> t
                for (int i = 2; i <= t; i++)
                {
                    //check so nguyen to
                    if (LaSoNguyenTo(i))
                    {
                        sum = sum + i;
                    }

                }
                Console.Write("{0} ", sum);
            }
            else
            {
                Console.WriteLine("sádfdf");
            }
            
            Console.ReadKey();

        }

        static bool LaSoNguyenTo(int n)
        {
            // Neu n < 2 thi khong phai la SNT
            if (n < 2)
            {
                return false;
            }

            // 5
            // 2-4
            // 8
            // 1-7
            for (int i = 2; i < (n - 1); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
