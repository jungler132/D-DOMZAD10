using System;
using System.Collections.Generic;
using System.Text;

namespace PracticLesson1
{
    public class Student
    {
        private int book_number;
        public int Book_number
        {
            get
            {
                return book_number;
            }
            set
            {
                book_number = value;
            }
        }
        private int course_number;
        public int Course_number
        {
            get
            {
                return course_number;
            }
            set
            {
                course_number = value;
            }
        }
        private string student_name;
        public string Student_name
        {
            get
            {
                return student_name;
            }
            set
            {
                student_name = value;
            }
        }
        private int student_age;
        public int Student_age
        {
            get
            {
                return student_age;
            }
            set
            {
                student_age = value;
            }
        }
        public Student()
        {

        }
        public Student(int Book_number , int Course_number , string Student_name , int Student_age)
        {
            this.Book_number = book_number;
            this.Course_number = course_number;
            this.Student_name = student_name;
            this.Student_age = student_age;
        }
        public void Vvod()
        {
            Console.WriteLine("Nomer Knigi");
            Book_number = tryparse();
            Console.WriteLine("Nomer kursa");
            Course_number = tryparse();
            Console.WriteLine("Ima");
            Student_name = valid_name();
            Console.WriteLine("Vozrast");
            Student_age = tryparse();
        }
        public void Show_Info()
        {
            Console.WriteLine($"Номер зачетной книги -- {book_number}");
            Console.WriteLine($"Курс номер  -- {course_number}");
            Console.WriteLine($"Имя студента  -- {student_name}");
            Console.WriteLine($"Возраст студента  -- {student_age}");
        }
        public static int tryparse()
        {
            int num1;
            bool triger = false;
            do
            {
                Console.WriteLine("Enter number");
                if (int.TryParse(Console.ReadLine(), out num1) && num1 > 0)
                {
                    triger = true;
                }
                else
                {
                    Console.WriteLine("wrong number try again");
                    continue;
                }
            }
            while (triger == false);
            return num1;
        }
        public static string valid_name()
        {
            string name;
            bool triger = false;
            do
            {
                Console.WriteLine("Enter name");
                bool v = true;
                name = Console.ReadLine();
                foreach (char a in name)
                {
                    if (a >= '0' && a <= '9')
                    {
                        v = false;
                        Console.WriteLine("Введите корректное имя.");
                        break;

                    }
                    continue;
                }
                if (v == false)
                {
                    continue;
                }
                triger = true;
            }
            while (triger == false);
            return name;
        }
    }
    public class Student_2 : Student
    {
        string theme;
        public Student_2()
        {
           
        }
        public string Theme
        {
            get
            {
                return theme;
            }
            set
            {
                theme = value;
            }
        }
        public Student_2(int Book_number, int Course_number, string Student_name, int Student_age)
            : base(Book_number, Course_number, Student_name, Student_age)
        {
            this.Theme = theme;
        }
        public new void Show_Info()
        {
            base.Show_Info();
        }

    }
}
