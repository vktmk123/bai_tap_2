using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_2.Inheritance
{
    public class Student : Person
    {
        public int numCourses = 0;
        public string[] courses = { };
        public int[] grades = { };

        public Student(string name, string address) : base()
        {
            this.Name = name;
            this.Address = address;
        }
        
        public void AddCourseGrade(string course, int grade)
        {
            int[] numCourses = {};
            for (int i = 0; i < numCourses.Length; i++)
            {
                courses[i] = course;
                grades[i] = grade;
            }

        }

        public void PrintGrades()
        {
                Console.WriteLine("Grade = " + grades);
        }

        public double GetAverageGrade()
        {
            double sum = 0;
            for(int i = 0; i < grades.Length; i++)
            {
                sum += grades[i];
            }
            return sum / grades.Length;
        }

        public override string ToString()
        {
            return "Student: name " + Name + "(Address: " + Address + ")";  
        }

    }
}
