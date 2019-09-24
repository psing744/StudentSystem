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
    }
}
