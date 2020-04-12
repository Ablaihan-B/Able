using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Able.Models.Students;
using Microsoft.AspNetCore.Mvc;

namespace Able.Controllers
{
    public class StudentsController : Controller
    {



        static List<Student> students = new List<Student>
    {
        new Student { Name = "Ablaihan", Surname = "Bexeit", Birth = new DateTime(01/07/2000),
            Group = "CSSE-1703" 
        },
    };



        public IActionResult Index()
        {

            return View(students);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Student student)
        {
            string name = student.Name;
            string surname = student.Surname;
            DateTime birth = student.Birth;
            string group = student.Group;
            string data = Convert.ToString(birth);

            string id = Char.ToString(data[0]) + Char.ToString(data[1])+ name[0] + name[1] + surname[0] + surname[1] + group[group.Length - 2] + group[group.Length - 1];

            Student st = new Student {Id = id,Name = name,Surname = surname,Birth = birth,Group = group};

            students.Add(st);

            return View("Index", students);
        }


        public IActionResult Search(string text)
        {
            text = text.ToLower();
            var searchedStudents = students.Where(students => students.Name.ToLower().Contains(text)
                                            || students.Surname.ToLower().Contains(text)
                                            || students.Group.ToLower().Contains(text))
                                        .ToList();
            return View("Index", searchedStudents);
        }


    }
}