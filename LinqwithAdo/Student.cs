using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinqwithAdo
{
    public class Student
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public static List<Student> GetAllStudent()
        {
            List<Student> stu = new List<Student>();
            Student student1 = new Student
            {
                id = 101,
                Name="BHU",
                Gender="female"
            };
            stu.Add(student1);

            Student student2 = new Student
            {
                id = 102,
                Name = "man",
                Gender = "male"
            };
            stu.Add(student2);
            Student student3 = new Student
            {
                id = 103,
                Name = "harvy",
                Gender = "female"
            };
            stu.Add(student3);
            return stu;
        }
    }
}