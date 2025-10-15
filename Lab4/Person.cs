using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab4
{
    public abstract class Person
    {

        public String name { get; set; }
        public int age { get; set; }            
        public String gender { get; set; }
        public DateTime DateofBirth { get; set; }

        public abstract void DisplayInfo();

    }
}
