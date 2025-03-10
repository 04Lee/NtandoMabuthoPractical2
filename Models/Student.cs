using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NtandoMabuthoStudyGroupP2.Models
{
	public class Student
	{
        [Display(Name = "STUDENT NUMBER")]
        public int StudentNumber { get; set; }

        [Display(Name = "NAME")]
        public string FirstNaam { get; set; }

        [Display(Name = "SURNAME")]
        public string Surname { get; set; }

        [Display(Name = "EMAIL ADDRESS")]
        public string Email { get; set; }

        [Display(Name = "MYLINK")]
        public string myLink { get; set; }

    }
}
