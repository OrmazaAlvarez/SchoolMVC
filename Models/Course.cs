using System;
using System.Collections.Generic;

namespace SchoolMVC.Models
{
    public class Course:SchoolBaseObject
    {
        public WorkdayType WorkDay { get; set; }
        public List<Subject> Subjects{ get; set; }
        public List<Student> Students{ get; set; }

        public string Address { get; set; }
    }
}