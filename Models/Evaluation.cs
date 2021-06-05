using System;

namespace SchoolMVC.Models
{
    public class Evaluation:SchoolBaseObject
    {
        public Student Student { get; set; }
        public Subject Subject  { get; set; }

        public float Nota { get; set; }

        public override string ToString()
        {
            return $"{Nota}, {Student.Name}, {Subject.Name}";
        }
    }
}