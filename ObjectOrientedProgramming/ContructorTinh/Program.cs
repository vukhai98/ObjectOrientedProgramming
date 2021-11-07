using System;

namespace ContructorTinh
{
    class Color
    {
        // Giả sử màu chủ đạo là 1 chuỗi ký tự lưu tên màu tương ứng
        public static string ColorChuDao;
        // Dùng static Contructor để kiểm tran ngày hiện tại và khởi tạo cho biến tĩnh ColorChuDao
        static Color()
        {
            DateTime now = DateTime.Now;
            // lấy ra thứ ngày hiện tại và so sánh với 7 ngày trong tuần 
            switch (now.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    ColorChuDao = "Yellow";
                    break;
                case DayOfWeek.Monday:
                    ColorChuDao = "Blue";
                    break;
                case DayOfWeek.Tuesday:
                    ColorChuDao = "Green";
                    break;
                case DayOfWeek.Wednesday:
                    ColorChuDao = "Black";
                    break;
                case DayOfWeek.Thursday:
                    ColorChuDao = "White";
                    break;
                case DayOfWeek.Friday:
                    ColorChuDao = " Red";
                    break;
                case DayOfWeek.Saturday:
                    ColorChuDao = "Pink";
                    break;
                default:
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mau chu dao ngay hom nay la : "+Color.ColorChuDao);
            Console.ReadLine();
        }
    }
}
