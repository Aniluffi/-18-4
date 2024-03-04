using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Persone
    { 
        protected string Name { get; set; }
        protected string Surname { get; set; }
        protected DateTime BDay { get; set; }
        protected string Faculty { get; set; }

        protected Persone(string name, string surname, DateTime bDay, string faculty)
        {
            Name = name;
            Surname = surname;
            BDay = bDay;
            Faculty = faculty;
        }

       public int GetAge()
        {
            return DateTime.Now.Year - BDay.Year; 
        }

     

        public abstract string Info();
    }
}
