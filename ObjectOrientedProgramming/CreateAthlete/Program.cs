using System;

namespace CreateAthlete
{
    class Program
    {
        static void Main(string[] args)
        {
            Athlete a1 = new Athlete();
            a1.nameAthlete = "Vu Minh Khai";
            a1.ageAthlete = 23;
            a1.sport = "Soccer";
            a1.weight = 75.00;
           // a1.Height = 1.75;
            a1.Info();
            Athlete a2 = new Athlete("Nguyen Van A", 21, "Baseball", 80, 1.70);
            a2.Info();
            Athlete a3 = new Athlete("Nguyen Van B ", 22, "Swinm", 90, 1.85);
           
          
        }
    }
}
