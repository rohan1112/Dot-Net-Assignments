//1.Open previous example of Class student
//As soon as you run your code it should print name of school

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        string name;
        int maths, science, eng;

        static Student()
        {
            Console.WriteLine("Welcome to 901 College!!!!!!!!!!!!");
        }
        public Student(string name, int maths, int science, int eng)
        {
            this.name = name;
            this.maths = maths;
            this.science = science;
            this.eng = eng;
        }

        public string Studentname
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int totalMarks()
        {
            return maths + science + eng;
        }

        public string studentDetails()
        {
            return string.Format("Name={0} Total Marks {1}", name, totalMarks());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Tejas", 80, 90, 85);
            Student s2 = new Student("Pratik", 70, 91, 86);
            Student s3 = new Student("Yash", 88, 80, 85);

            Console.WriteLine(s1.studentDetails());
            Console.WriteLine(s2.studentDetails());
            Console.WriteLine(s3.studentDetails());
        }
    }
}