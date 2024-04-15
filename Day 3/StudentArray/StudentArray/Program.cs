using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentArray
{
    class Student
    {
        int id;
        string name;
        double percentage;

        public Student(int id, string name, double percentage)
        {
            this.id = id;
            this.name = name;
            this.percentage = percentage;
        }

        public string display()
        {
            return string.Format("name={0} percentage={1}",name,percentage);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(1, "qwe", 78.23);
            Student s2 = new Student(2, "wefr", 98.05);
            Student s3 = new Student(3, "qwdvfge", 88.63);
            Student s4 = new Student(4, "qwwfwe", 82.23);
            Student s5 = new Student(5, "qwvdfe", 72.93);

            Student[] stuArr= new Student[] { s1, s2, s3, s4 ,s5};

            for(int i=0;i<stuArr.Length;i++)
            {
                Student student = stuArr[i];
                Console.WriteLine(student.display());
            }
        }
    }
}
