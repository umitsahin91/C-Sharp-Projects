using LinqPractices.DbOperations;
using LinqPractices.Entities;
using System;
using System.Linq;

namespace LinqPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            DataGenerator.Initialize();
            LinqDbContext _context = new LinqDbContext();
            var students = _context.Students.ToList<Student>();

            //Find()
            Console.WriteLine("***Find***");
            var student = _context.Students.Where(s => s.StudentId == 1).FirstOrDefault();
            Console.WriteLine(student.Name);

            student = _context.Students.Find(1);
            Console.WriteLine(student.Name);

            //FirstOrDefault()
            Console.WriteLine("***FirstOrDefault***");
            student = _context.Students.Where(s => s.Surname == "Arda").FirstOrDefault();
            Console.WriteLine(student.Name);

            student = _context.Students.FirstOrDefault(s => s.Surname == "Arda");
            Console.WriteLine(student.Name);

            //SingleOrDefault()
            Console.WriteLine("***SingleOrDefault***");
            student = _context.Students.SingleOrDefault(s => s.Name == "Deniz");
            Console.WriteLine(student.Surname);

            //ToList()
            Console.WriteLine("***ToList***");
            var studentList = _context.Students.Where(s => s.ClassId == 2).ToList();
            Console.WriteLine(studentList.Count);
            foreach (var s in studentList)
            {
                Console.WriteLine(s.Name);
            }

            //OrderBy()
            Console.WriteLine("***OrderBy***");

            studentList = _context.Students.OrderBy(s => s.StudentId).ToList();
            foreach (var s in studentList)
            {
                Console.WriteLine(s.StudentId+ "-"+s.Name+" " +s.Surname);
            }

            //OrderByDescending()
            Console.WriteLine("***OrderByDescending***");

            studentList = _context.Students.OrderByDescending(s => s.StudentId).ToList();
            foreach (var s in studentList)
            {
                Console.WriteLine(s.StudentId + "-" + s.Name + " " + s.Surname);
            }

            //Anonymous Object Result
            Console.WriteLine("***Anonymous Object Result***");

            var anonymousObject = _context.Students
                .Where(s => s.ClassId == 2)
                .Select(x => new { Id = x.StudentId, FullName = x.Name + " " + x.Surname });

            foreach (var obj in anonymousObject)
            {
                Console.WriteLine(obj.Id+"-"+obj.FullName);
            }

        }
    }
}
