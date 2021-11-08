using System;

namespace Interface
{
    interface ISpeak
    {
        // Khai báo phương thức nhưng không định nghĩa nội dung
        void Speak();
    }
    class Animal : ISpeak // lớp Animal thực thi interface ISpeak
    {
        public void Speak()
        {
            Console.WriteLine("Animal is speaking... ");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            ISpeak animal = new Animal();
            animal.Speak();
            Console.ReadKey();
        }
    }
}
