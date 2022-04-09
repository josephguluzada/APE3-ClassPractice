using APE3.Models;
using System;

namespace APE3
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            double point;
            
            do
            {
                Console.WriteLine("Enter the age");
                age = Convert.ToInt32(Console.ReadLine());

            } while (age < 0);

            do
            {
                Console.WriteLine("Enter the point");
                point = Convert.ToDouble(Console.ReadLine());
                Console.Clear();

            } while (point < 0 || point > 100);


            Student student1 = new Student("Mushfiq","Cahadzada",age,point);

            student1.ShowInfo();

            //student1.Age = -90;

            //Console.WriteLine(student1.Age);

        }
    }
}
