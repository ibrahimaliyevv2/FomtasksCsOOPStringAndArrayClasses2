using System;
using System.Collections.Generic;
using System.Text;

namespace GraduatedStudent
{
    class Student
    {
        public Student(double point)
        {
            this.Point = point;
        }

        public string Name;
        public string Surname;
        public int Group;
        public double Point;
        public bool IsGraduated;

        public void PrintFullName()
        {
            Console.WriteLine($"Full name: {Name} {Surname}");
        }


        public void GetInfo()
        {
            string check;
            if (IsGraduated)
            {
                check = "graduated";
            }
            else
            {
                check = "is still student";
            }
            Console.WriteLine($"Full name: {Name} {Surname}, Group number: {Group}, Point: {Point}, Graduated or not: {check}");
        }

        public void CheckPoint()
        {
            if (Point > 80)
            {
                Console.WriteLine("Student can go to second exam.");
            }
            else
            {
                Console.WriteLine("Student can not go to second exam.");
            }
        }
    }
}
