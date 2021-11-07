using System;

namespace Ex2AccessRange
{
    class Student
    {
        private string CodeStudent;
        private string Name;
        private double DiemToan;
        private double DiemVan;
        private double diemLy;
       
        // đây là phương thức truy vấn giá trị của  thuộc tính CodeStudent
        // Vì thế phương thức sẽ trả về string ( trùng với kiểu thược tính CodeStudent
        //public string getCodeStudent()
        //{
        //    return CodeStudent;
        //}
        //// đây là phương thức cập nhật giá trị cho thuộc tính DiemToan
        //public void setDiemToan(int diemtoan)
        //{
        //    DiemToan = diemtoan;
        //}
        //public double DiemLy
        //{
        //    get { return diemLy; }
        //    set { diemLy = value; }
        //}
        public double DiemLy
        {
            get { return diemLy; }
            set
            {
                if (value <= 10 || value>=0)
                {
                    diemLy = value;
                }    
            }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student Sta = new Student();
            Sta.DiemLy = 8; // khi gán giá trị cho property thì  các câu lệnh trong set được thực hiện
            Console.WriteLine("Diem ly cua ban la: " + Sta.DiemLy);
            Console.ReadKey();
        }
       
    }
}
