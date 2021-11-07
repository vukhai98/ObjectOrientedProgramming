using System;

namespace Access_range
{
    // vì không chỉ định từ khóa cụ thể nên class Student có phạm vi là internal 
    class Student
    {
        // Các thuộc tính đều mang phạm vi la private . VÌ thế chỉ được sử dụng nội bộ trong class 
        // Ra bên ngoài sẽ ko truy cập đc

        private string CodeStudent;
        private string Name;
        private double DiemToan;
        private double DiemVan;
        // Phương thức có phạm vi  là public nên có thể sử bên ngoài class
        // Vì nằm trong lớp nên phương thức này có thể sử dụng các thuộc tính ở trên .
        public void InThongTinDiemTB()
        {
            double DTB = (DiemToan + DiemVan) / 2;
            Console.WriteLine(" Sinh Vien " + Name + " co diem trung binh là: " + DTB);
            
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student STA = new Student();
            STA.InThongTinDiemTB();
                // rõ ràng các thuộc tính đều đã bị ẩn đi  va không thể truy cập chỉ còn lại các thành phần public
               
        }
    } 
}
