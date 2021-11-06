using System;

namespace Class
{
    //class Animal
    //{
    //    public double weight;
    //    public double height;

    //    public void Info()
    //    {
    //        /* 
    //         * Các phương thức bên trong lớp có thể gọi  đến các thành phần khác (bao gồm thuộc tính và phương thức) trong lớp đó .
    //         * Gía trị của các thuộc tính này có thể được khởi tạo   đâu đó từ bên trong lớp hoặc từ bên ngoài truyền vào .
    //         */
    //        Console.WriteLine(" Height: "  +  height  +  " Weight: " + weight);
    //    }

    //}
    class Cat
    {
        public double Weight;
        public double Height;
        public string Color;
        public double? Age;
        /*
         * Contructor không có tham số 
         */
        public Cat()
        {
            Weight = 800;
            Height = 10;
            // Contructor có tham số 
        }
        public Cat(int w, int h,string color = null, double? age = null)
        {
            Weight = w;
            Height = h;
        }

        //public Cat(int w, int h, double? age = null)
        //{
        //    weight = w;
        //    height = h;
        //    color = "black";
        //}
        public void Info()
        {
            Console.WriteLine(" Height: "  + Height +  " Weight: " + Weight);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            #region Example Class
            //Animal dog = new Animal();

            //dog.weight = 2; // gán giá trị cho các thuộc tính của đối tượng 

            //dog.height = 50;

            //Animal cat = new Animal();
            //cat.weight = 1;
            //cat.height = 30;

            //dog.Info(); // gọi phương thức đối tượng 
            //cat.Info();

            #endregion
            #region Contructor
            Cat blackCat = new Cat(); // khi new Cat bạn không truyền  tham số vào thì  contruct mặc định sẽ tự động được gọi để tạo giá trị  mặc định cho các thuộc tính của đối tượng blackCat 
           
            blackCat.Info(); // In ra thông tin Weight,Height có thực sự được khởi tạo chưa .
            Cat whiteCat = new Cat(1200,44);
            whiteCat.Info();
            #endregion
        }
    }
  
}
