using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication11.Context;

namespace WebApplication11.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        testEntities dbobj = new testEntities();
        public ActionResult Student()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddStudent(student model)
        {
            if (ModelState.IsValid)
            {
                student st = new student();
                st.Name = model.Name;
                st.Fname = model.Fname;
                st.Email = model.Email;
                st.Mobile = model.Mobile;
                st.Description = model.Description;

                dbobj.students.Add(st);
                dbobj.SaveChanges();
            }
            ModelState.Clear();


            return View("student");
        }
    }
}