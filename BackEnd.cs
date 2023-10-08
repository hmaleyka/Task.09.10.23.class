using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassHometask
{
    internal class BackEnd
    {
        public string name;
        public string surname;
        public int age;
        public string experience;
        public int SqlExperienceYear;

        public BackEnd(string name)
        {
            this.name = name;
        }

        public BackEnd(string name,string surname) :this(name)
        {
            
            this.surname = surname;
        }
        public BackEnd(string name, string surname, string experience) :this(name, surname)
        {
           
            this.experience = experience;
        }
        public void getFullInfo()
        {
            Console.WriteLine($"{name} {surname} {experience}");
        }

    }
}



