using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentSystem.Models;

namespace StudentSystem.Controllers
{
    public class HomeController:Controller
    {
        public ViewResult Index()
        {
            Student TestStudent = new Student() { FirstName = "Ram" };
            return View(TestStudent);
        }

        public ViewResult ListStudents()
        {
            List<Student> students = new List<Student>() {
                new Student { CourseCode = "COMP229", Email="pritpal@gmail.com",FirstName = "Pritpal",FullTime=true,Gpa=1.8,LastName="Singh",StudentId=1 },
                new Student { CourseCode = "COMP100", Email="rahul@gmail.com",FirstName = "Rahul",FullTime=false,Gpa=3.9,LastName="Arora",StudentId=2 },
                new Student { CourseCode = "C", Email="manik@gmail.com",FirstName = "Manik",FullTime=true,Gpa=3.5,LastName="Viz",StudentId=3 },
                new Student { CourseCode = "COMP123", Email="baljit@gmail.com",FirstName = "Baljit",FullTime=false,Gpa=4.3,LastName="Kaur",StudentId=4 }
            };
            return View(students);
        }
    }
}
