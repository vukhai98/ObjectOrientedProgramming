using System;

namespace StaticVariable
{
    class Cat
    {
        private int weight;
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        private int height;
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public static int Count = 0;
        public Cat()
        {
            weight = 20;
            height = 500;
            // Vì contructor chit được gọi khi đối tượng được tạo ra nên ta sẽ tăng Count ở đây.
            Count++;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("So luong meo ban dau : " + Cat.Count);
            Cat BlackCat = new Cat(); // tạo ra con mèo đầu tiên 
            Console.WriteLine("So luong meo hien tai : " + Cat.Count);
            Cat WhiteCat = new Cat(); // tạo ra con mèo thứ 2
            Console.WriteLine("So luong meo hien tai : " + Cat.Count);
            Console.ReadKey();
        }
    }
}
