using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RiyaStudyGroup.Models;

namespace RiyaStudyGroup.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult ListStudent()
        {
            List<Models.StudentModel> students = new List<Models.StudentModel>();

            students.Add(new Models.StudentModel { StudentNumber = "u23648156", Name = "Riya", Surname = "Naidoo", Email = "u23648156@tuks.co.za", myLink = "~/HTML/Riya.html" });
            students.Add(new Models.StudentModel { StudentNumber = "u23563908", Name = "Anzelle", Surname = "Van Beek", Email = "u23563908@tuks.co.za", myLink = "~/HTML/Anzelle.html" });
            students.Add(new Models.StudentModel { StudentNumber = "u23819767", Name = "Cynthia", Surname = "Mashaba", Email = "u23819767@tuks.co.za", myLink = "~/HTML/Cynthia.html" });
            students.Add(new Models.StudentModel { StudentNumber = "u23585073", Name = "Lwandiso", Surname = "Thanda", Email = "u23585073@tuks.co.za", myLink = "~/HTML/Lwandiso.html" });
            students.Add(new Models.StudentModel { StudentNumber = "u23699869", Name = "Kiara", Surname = "Govender", Email = "u23699869@tuks.co.za", myLink = "~/HTML/Kiara.html" });

            return View(students);
        }
    }
}