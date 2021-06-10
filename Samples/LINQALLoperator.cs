using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace Samples
{
    public class Subject
    {
        public string SubjectName { get; set; }
        public int Marks { get; set; }
    }
    public class Student1
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }
        public List<Subject> Subjects { get; set; }

        public static List<Student1> GetAllStudnets()
        {
            List<Student1> listStudents = new List<Student1>()
            {
                new Student1{ID= 101,Name = "Preety", TotalMarks = 265,
                    Subjects = new List<Subject>()
                    {
                        new Subject(){SubjectName = "Math", Marks = 80},
                        new Subject(){SubjectName = "Science", Marks = 90},
                        new Subject(){SubjectName = "English", Marks = 95}
                    }},
                new Student1{ID= 102,Name = "Priyanka", TotalMarks = 278,
                    Subjects = new List<Subject>()
                    {
                        new Subject(){SubjectName = "Math", Marks = 90},
                        new Subject(){SubjectName = "Science", Marks = 95},
                        new Subject(){SubjectName = "English", Marks = 93}
                    }},
                new Student1{ID= 103,Name = "James", TotalMarks = 240,
                    Subjects = new List<Subject>()
                    {
                        new Subject(){SubjectName = "Math", Marks = 70},
                        new Subject(){SubjectName = "Science", Marks = 80},
                        new Subject(){SubjectName = "English", Marks = 90}
                    }},
                new Student1{ID= 104,Name = "Hina", TotalMarks = 275,
                    Subjects = new List<Subject>()
                    {
                        new Subject(){SubjectName = "Math", Marks = 90},
                        new Subject(){SubjectName = "Science", Marks = 90},
                        new Subject(){SubjectName = "English", Marks = 95}
                    }},
                new Student1{ID= 105,Name = "Anurag", TotalMarks = 255,
                    Subjects = new List<Subject>()
                    {
                        new Subject(){SubjectName = "Math", Marks = 80},
                        new Subject(){SubjectName = "Science", Marks = 90},
                        new Subject(){SubjectName = "English", Marks = 85}
                    }
                },
            };

            return listStudents;
        }
    }

   
    class LINQALLoperator
    {
        static void Main(string[] args)
        {
            //Using Method Syntax
            var MSResult = Student1.GetAllStudnets()
                            .Where(std => std.Subjects.All(x => x.Marks > 80)).ToList();

            //Using Query Syntax
            var QSResult = (from std in Student1.GetAllStudnets()
                            where std.Subjects.All(x => x.Marks > 80)
                            select std).ToList();
            foreach (var item in QSResult)
            {
                Console.WriteLine(item.Name + " " + item.TotalMarks);
            }
            Console.ReadKey();
        }
    }
}
