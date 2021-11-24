using System;
using System.Collections.Generic;
using System.Text;

namespace CreateAthlete
{
    class Athlete
    {
        public string nameAthlete { get; set; }
        public int ageAthlete { get; set; }
        public string sport { get; set; }
        public double weight { get; set; }
        public double height { get; set; }

        public Athlete()
        {

        }
        ~  Athlete()
        {

        }
        public Athlete(string name, int age, string _sport, double _wieght, double _height)
        {
            nameAthlete = name;
            ageAthlete = age;
            sport = _sport;
            weight = _wieght;
            height = _height;

        }
        public void Input()
        {
            Console.WriteLine("Moi ban nhap thong tin van dong vien:");
            Console.WriteLine("Name Athlete :");
            nameAthlete = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Age Athlete: ");
            ageAthlete = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sport: ");
            sport = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Weight: ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Height:");
        }
        public void Info()
        {
            Console.WriteLine("\nName: " + nameAthlete + "\nAge: " + ageAthlete + "\nSport: " + sport + "\nWeight: " + weight +" Kg "+ "\nHeight: " + height+" Cm ");
        }
        

    }
}
