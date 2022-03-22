using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    
   abstract class Person
    {
        public string Name { get; set; }
        private int age;
        public int Age 
        {
            get
            {
                return age;
            }
            set
            {
                if ((value < 18) || (value > 65))
                {
                    age = 18;
                }
                else
                {
                    age=value;
                }
            }
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

    }
}
