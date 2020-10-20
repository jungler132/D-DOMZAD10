using System;

namespace PracticLesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Vvod();
            Student_2 student_2 = new Student_2();
            student_2.Vvod();
            student.Show_Info();
            student_2.Show_Info();
            Console.ReadKey();
        }
    }
}
