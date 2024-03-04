using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Enrollee:Persone
    {   
        int Kurs { get; set; }

        public Enrollee(string name, string surname, DateTime bDay, string faculty,int kurs):base(name,surname,bDay,faculty)
        {
            Kurs = kurs;
        }


        public static Enrollee InputInfo()
        {
            Console.Write("Name");
            string name = Console.ReadLine();

            Console.Write("Surname");
            string surname = Console.ReadLine();

            Console.Write("Surname");
            DateTime bDay = DateTime.Parse(Console.ReadLine());

            Console.Write("Surname");
            string faculty = Console.ReadLine();

            Console.Write("Surname");
            int kurs = Int32.Parse(Console.ReadLine());

            return new Enrollee(name,surname,bDay,faculty,kurs);
        }

        public override string Info()
        {
            return $"Имя - {Name} \nФамилия - {Surname}\n Дата Рождения - {BDay}\n Факультет - {Faculty}\n Курс - {Kurs}";
        }
    }
}
