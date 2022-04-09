using System;
using System.Collections.Generic;
using System.Text;

namespace APE3.Models
{
    class Student : Person
    {
        private double _point;

        public int StudentId { get; set; }
        public double Point
        {
            get { return _point; }
            set 
            {
                if(value>= 0 && value <= 100)
                {
                    _point = value;
                }
            }
        }



        public Student(string name, string surname, int age, double point) : base(name, surname, age)
        {
            Point = point;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} Surname: {SurName} Age: {Age} Point: {Point}");
        }
    }
}
