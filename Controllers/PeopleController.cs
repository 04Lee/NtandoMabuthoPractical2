using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NtandoMabuthoStudyGroupP2.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult StudentDisplay()
        {
            List<Models.Student> students = new List<Models.Student>();
            {
                students.Add(new Models.Student { StudentNumber = 01234567, FirstNaam = "Jane", Surname = "Doe", Email = "jane.doe@tuks.co.za", myLink = "/HTML/p1.html" });
                students.Add(new Models.Student { StudentNumber = 12345678, FirstNaam = "John", Surname = "Doe", Email = "john.doe@tuks.co.za", myLink = "/HTML/p2.html" });
                students.Add(new Models.Student { StudentNumber = 23717662, FirstNaam = "Leo", Surname = "Mchunu", Email = "mchunuleo@tuks.co.za", myLink = "/HTML/p3.html" });
                students.Add(new Models.Student { StudentNumber = 29695682, FirstNaam = "Cosmo", Surname = "Logical", Email = "cosmology@gmail.com", myLink = "/HTML/p4.html" });
                students.Add(new Models.Student { StudentNumber = 28779832, FirstNaam = "Kenneth", Surname = "Ngubane", Email = "kenniengubane@gmail.com", myLink = "/HTML/p5.html" });



                return View(students);
            }
        }
    }
}