using System;
using System.Collections.Generic;

namespace SchoolMVC.Models
{
    public class Student: SchoolBaseObject
    {
        public List<Evaluation> Evaluations { get; set; } = new List<Evaluation>();
    }
}