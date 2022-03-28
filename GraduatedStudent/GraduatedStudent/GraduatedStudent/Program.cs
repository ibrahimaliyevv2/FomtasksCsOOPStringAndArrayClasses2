using System;

namespace GraduatedStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(81);
            student.Name = "Israfil";
            student.Surname = "Memmedov";
            student.Group = 24;
            student.IsGraduated = true;

            student.GetInfo();
            student.CheckPoint();



        }
    }
}
