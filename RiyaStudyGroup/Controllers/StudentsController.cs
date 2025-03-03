using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RiyaStudyGroup.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult ListStudent()
        {
            List<Models.StudentModel> students = new List<Models.StudentModel>();

            students.Add(new Models.StudentModel { StudentNumber = "u23648156", Name = "Riya", Surname = "Naidoo", Email = "u23648156@tuks.co.za" });
            students.Add(new Models.StudentModel { StudentNumber = "u01234567", Name = "Jane", Surname = "Doe", Email = "u01234567@tuks.co.za" });
            students.Add(new Models.StudentModel { StudentNumber = "u25976414", Name = "John", Surname = "Smith", Email = "u25976414@tuks.co.za" });
            students.Add(new Models.StudentModel { StudentNumber = "u20569245", Name = "Liam", Surname = "Payne", Email = "u20569245@tuks.co.za" });
            students.Add(new Models.StudentModel { StudentNumber = "u20695842", Name = "Jayden", Surname = "Perf", Email = "u20695842@tuks.co.za" });

            return View(students);
        }
    }
}