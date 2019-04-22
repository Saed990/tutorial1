using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tutorial.Models;


namespace tutorial.Controllers
{

    

    public class StudentController : Controller
    {
       static List<student> studentlist = new List<student> {
                new student{ ID=1, name="Ali", age=34},
                new student{ ID=2, name="Khalid", age=11},
                new student{ ID=3, name="Mohamad", age=34},
                new student{ ID=4, name="Saeed", age=11},
                new student{ ID=5, name="Ali", age=22},
                new student{ ID=6, name="Anas", age=40},
            };


        // GET: Student
        public ActionResult Index()
        {


            return View(studentlist);
        }

        public ActionResult Edit(int? id) {


            if (id>0)
            {
                student s = studentlist.Where(m => m.ID == id).FirstOrDefault();
                return View(s);
            }

            else
            {
                return View();
            }


        }

        [HttpPost]
        public ActionResult Edit(student std)
        {
            if (std.ID>0)
            {
                
                studentlist.Where(m => m.ID == std.ID).FirstOrDefault().name = std.name;
                studentlist.Where(m => m.ID == std.ID).FirstOrDefault().age = std.age;


                return RedirectToAction("Index");
            }

            else
            {
                int id = studentlist.Capacity;
                student n = new student { ID = id, age = std.age, name = std.name };
                studentlist.Add(n);
                return RedirectToAction("Index");
            }

        }


    }
}