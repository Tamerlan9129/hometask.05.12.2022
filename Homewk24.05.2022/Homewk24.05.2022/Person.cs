using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homewk24._05._2022
{
    class Person
    {
        public string Name;
        public string Surname;
        public int Age;
        public bool IsAdult;

        //public Person(string name, string surname) 
        //{
        //    //Name = name;
        //    //Surname = surname;

        //}
        public Person(string name,string surname,int age)//:this(name,surname)
        {
        Name = name;
        Surname = surname;
        Age = age;
            if (Age > 18)
            {
                IsAdult = true;
            }
            else {
                IsAdult = false;
            }
         }
    }
    
}
