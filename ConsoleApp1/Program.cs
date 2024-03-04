using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           

            List<Persone> list = new List<Persone>();

            bool flag = true;

            while(flag)
            {
                Console.WriteLine("Введите название");
                string s = Console.ReadLine();

                switch (s) 
                {
                    case "Абитуриент": list.Add(Enrollee.InputInfo()); break;
                    default: flag = false; break;
                }

                foreach (var z in list)
                {
                    Console.WriteLine(z.Info());
                }
            }
        }
    }
}
