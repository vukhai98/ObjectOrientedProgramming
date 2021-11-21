using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    public static class Helper
    {
        // function ....
        //input 
        //output
        public static bool SumCustom(int n, int sum, int t)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out n))
            {
                for (int i = 1; i <= n; i++)
                {
                    sum += t;
                    if (i < n)
                    {
                        Console.Write(" {0} +", t);
                    }
                    else
                    {
                        Console.Write(" {0} \n ", t);
                    }
                    t = i * 4 + 2;
                }
                Console.WriteLine("Tong cua day so S co {0} phan tu la: {1}", n, sum);
                //flag = false;
                // clear data
                // 
                //i = n = sum = 0;
                //input = string.Empty;
                return false;

            }
            else
            {
                Console.WriteLine("sai nhap lai");
            }
            return true;
        }


    }
}
