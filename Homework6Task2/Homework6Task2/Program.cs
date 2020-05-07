using System;

namespace Homework6Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 2

            // In this exercise you are asked to program three simple classes which keep track of the grading of a sample student.
            // The classes are called FirstCourse, SecondCourse, and Project.
            // A FirstCourse encapsulates a course name and a registration of passed / not passed for our sample student.
            // A SecondCourse encapsulates a course name and the grade of the student.
            // For grading we use the grades, numerical grades 10, 9, 8, 7, 6, 5.
            // You are also welcome use the enumeration.The grade 6 is the lowest passing grade.
            // In both FirstCourse and SecondCourse you should write a method called Passed.
            // The method is supposed to return whether our sample student passes the course.
            // The class Project aggregates two FirstCourse courses and two SecondCourse courses.
            // You can assume that a project is passed if at least three out of the four courses are passed. 
            // Write a method Passed in class Project which implements this passing policy.
            // In Main method initialize 2 FirstCourse objects, 2 SecondCourse objects and 1 Project object. 
            // Add both FirstCourse and both SecondCourse objects like a properties to Project object. 
            // Call Project's object Passed method to see if the student passed.

            FirstCourse course1 = new FirstCourse("C# Basic", true);
            FirstCourse course2 = new FirstCourse("C# Advanced", true);
            SecondCourse course3 = new SecondCourse("JS Bacis", Grades.five);
            SecondCourse course4 = new SecondCourse("JS Advanced", Grades.five);
            Project project = new Project(course1, course2, course3, course4);
            project.Passed();            
        }
        public class FirstCourse
        {
            public FirstCourse(string courseName, bool pass)
            {
                CourseName = courseName;
                passed = pass;
            }

            public string CourseName;
            public bool passed;

            public bool Passed()
            {
                if (passed)         
                    return true;
                else
                    return false;
            }
        }

        public class SecondCourse
        {
            public SecondCourse(string courseName, Grades grade)
            {
                CourseName = courseName;
                Grades = grade;
            }
            public string CourseName;
            public Grades Grades;

            public bool Passed()
            {
                if ((int) Grades != 5)  
                    return true;
                else 
                    return false;        
            }
        }
        public class Project
        {
            public Project(FirstCourse course1, FirstCourse course2, SecondCourse course3, SecondCourse course4)
            {
                Course1 = course1;
                Course2 = course2;
                Course3 = course3;
                Course4 = course4;
            }

            FirstCourse Course1;
            FirstCourse Course2;
            SecondCourse Course3;
            SecondCourse Course4;

            public void Passed() 
            {
                bool[] array = { Course1.Passed(), Course2.Passed(), Course3.Passed(), Course4.Passed() };
                var course = 0;

                foreach (var item in array)
                {
                    if (item == true)
                    {
                        course++;
                    }
                }
                if (course > 2)
                {
                    Console.WriteLine("The student has passed.");
                }
                else
                {
                    Console.WriteLine("The student has failed.");
                }
            }
        }
        public enum Grades
        {
            ten = 10,
            nine = 9,
            eight = 8,
            seven = 7,
            six = 6,
            five = 5,
        }
    }
}

