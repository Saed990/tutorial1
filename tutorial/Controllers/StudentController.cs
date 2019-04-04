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
        // GET: Student
        public ActionResult Index()
        {
            var studentlist = new List<student> {
                new student{ ID=1, name="Ali", age=34},
                new student{ ID=2, name="Khalid", age=11},
                new student{ ID=3, name="Mohamad", age=34},
                new student{ ID=4, name="Saeed", age=11},
                new student{ ID=5, name="Ali", age=22},
                new student{ ID=6, name="Anas", age=40},
            };

            return View(studentlist);
        }

        public ActionResult edit(int id) {
            //do something
            return View();
        }

        [HttpPost]
        public ActionResult edit(student std)
        {
            var id = std.ID;
            var name = std.name;
            var age = std.age;

            //update database
            return RedirectToAction("Index");
        }

        [ActionName("Find")]
        public ActionResult GetById(int id)
        {
            return View();
        }

        [NonAction]
        public ActionResult GetByID(int id)
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post | HttpVerbs.Get)]
        public ActionResult GetandPost()
        {
            return View();
        }


    }
}