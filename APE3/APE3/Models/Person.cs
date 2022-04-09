using System;
using System.Collections.Generic;
using System.Text;

namespace APE3.Models
{
    class Person
    {
        private int _age;
        private string _name;

        public string Name
        {
            get { return _name; }
            set 
            {
                if(value.Length > 0)
                {
                    _name = value;
                }
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
            }
        }

        public string SurName { get; set; }

        public Person(string name, string surname, int age)
        {
            Name = name;
            SurName = surname;
            Age = age;
        }

    }
}
