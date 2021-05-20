using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solution2
{
    class Program
    {
        static void Main(string[] args)
        {
            student[] Students = new student[]
            {
                new student { StudentID = 1, StudentName = "Shammi", StudentGender = "Female", StudentAge = 23, TspID = 1, BatchID = 101},
                new student { StudentID = 2, StudentName = "Trisha", StudentGender = "Female", StudentAge = 23, TspID = 2, BatchID = 103},
                new student { StudentID = 3, StudentName = "Radee", StudentGender = "Male", StudentAge = 10, TspID = 1, BatchID = 103},
                new student { StudentID = 4, StudentName = "Nitu", StudentGender = "Female", StudentAge = 16, TspID = 3, BatchID = 104},
                new student { StudentID = 5, StudentName = "Nafiya", StudentGender = "Female", StudentAge = 18, TspID = 1, BatchID = 102},
                new student { StudentID = 6, StudentName = "Shuvo", StudentGender = "Male", StudentAge = 26, TspID = 2, BatchID = 105},
                new student { StudentID = 7, StudentName = "Jelly", StudentGender = "Female", StudentAge = 28, TspID = 1, BatchID = 101},
                new student { StudentID = 8, StudentName = "Suparna", StudentGender = "Female", StudentAge = 25, TspID = 2, BatchID = 105},
                new student { StudentID = 9, StudentName = "Raj", StudentGender = "Male", StudentAge = 21, TspID = 1, BatchID = 102},
                new student { StudentID = 10, StudentName = "Sharmin", StudentGender = "Female", StudentAge = 30, TspID = 3, BatchID = 104}
            };

            TSP[] TSP = new TSP[]
            {
                new TSP { TspID = 1, TspName = "JPIT" },
                new TSP { TspID = 2, TspName = "BITM" },
                new TSP { TspID = 3, TspName = "PPNT" }
             };

            Batch[] Batch = new Batch[]
            {
                new Batch { BatchID = 101, BatchName = "C#" },
                new Batch { BatchID = 102, BatchName = "ASP.NET" },
                new Batch { BatchID = 103, BatchName = "SQL" },
             };


            /*=========================Select,where======================*/
            var StudentInfo = Students
            .Where(sg => String.Equals(sg.StudentGender, "Female"))
            .Select(std => new {
                std.StudentName,
                std.StudentID,
                std.StudentGender,
                std.StudentAge,
                std.TspID,
                std.BatchID
            });


            /*=========================Joining==========================*/
            /*Console.WriteLine("--------Join in SQL Query Syntax--------");
             var StudentInfo2 = from std in Students
                                join dpt in Departments on std.DepartmentID equals dpt.DepartmentID
                                select new { std.StudentName, std.StudentID, std.StudentGender, dpt.DepartmentName, };

             foreach (var info in StudentInfo2)
             {
                 //Console.WriteLine(info.StudentName + " = " + info.DepartmentName);
                 Console.WriteLine(info);
             }
             Console.WriteLine('\n');

             Console.WriteLine("--------Join in Lambda Expression--------");
             var StudentInfo = Students

                 .Select(std => new { std.StudentName, std.StudentID, std.DepartmentID, std.StudentGender, std.CourseCode })
                 .Join(Departments, st => st.DepartmentID, dp => dp.DepartmentID, (st, dp) => new { st.StudentName, st.StudentID, st.StudentGender, Department = dp.DepartmentName })
                 //.Join(Courses, s => s.CourseCode, c => c.CourseCode, (s, c) => new { s.StudentName, s.StudentID, CourseName = c.CourseName})
                 .OrderBy(a => a.StudentName).ThenBy(a => a.StudentName);
            */
            foreach (var info in StudentInfo)
            {
                Console.WriteLine(info);
            }
            Console.WriteLine('\n');


            /*=============================Where==========================*/
            Console.WriteLine("--------Where in SQL Query Syntax--------");
            var stdName = from student in Students
                          where student.StudentName.StartsWith("S")
                          select student.StudentName;

            foreach (var s in stdName)
            {
                Console.WriteLine(s);
            }


            Console.WriteLine("--------Where in Lambda Expression--------");
            var stdName1 = Students.Where(e => e.StudentName.StartsWith("S"));

            foreach (var s in stdName1)
            {
                Console.WriteLine(s.StudentName);
            }
            Console.WriteLine('\n');


            /*=========================Group By============================*/
            Console.WriteLine("--------Group By Gender in SQL Query Syntax--------");
            var groupStd = from std in Students
                           group std by std.StudentGender;

            foreach (var g in groupStd)
            {
                Console.WriteLine(g.Key + " = " + g.Count());
            }

            Console.WriteLine("--------Group By Gender in Lambda Expression--------");
            var groupStd1 = Students.GroupBy(e => e.StudentGender);

            foreach (var g in groupStd1)
            {
                Console.WriteLine(g.Key + " = " + g.Count());
            }

            Console.WriteLine('\n');


            /*=======================Use of Aggregate=======================*/
            Console.WriteLine("--------------Use of Aggregate-----------");
            //Count
            var totalStudents = Students.Count();

            Console.WriteLine("\nNumber of Total Students: {0}", totalStudents);

            int SumOfStudentsAge = Students.Aggregate<student, int>(0,
                                                (totalAge, s) => totalAge += s.StudentAge);

            Console.WriteLine("\nSum of All Student Age: {0}", SumOfStudentsAge);

            //Average
            var avgAge = Students.Average(s => s.StudentAge);

            Console.WriteLine("\nAverage Age of Students: {0}", avgAge);

            //Min & Max
            var oldest = Students.Max(s => s.StudentAge);

            Console.WriteLine("\nOldest Student Age: {0}", oldest);

            var Smallest = Students.Min(s => s.StudentAge);

            Console.WriteLine("\nSmallest Student Age: {0}", Smallest);

            Console.ReadKey();
        }
    }
}
