using System.Collections.Generic;

namespace SchoolMVC.Models
{
    public class School:SchoolBaseObject
    {
        public int CreationYear { get; set; }

        public string Country { get; set; }
        public string City { get; set; }

        public string Address { get; set; }

        public SchoolType SchoolType { get; set; }
        public List<Course> Courses { get; set; }

        public School(){

        }
        
        public School(string name, int year) => (Name, CreationYear) = (name, year);

        public School(string name, int year, 
                       SchoolType type, 
                       string country = "", string city = "") : base()
        {
            (Name, CreationYear) = (name, year);
            Country = country;
            City = city;
        }

        public override string ToString()
        {
            return $"Nombre: \"{Name}\", Tipo: {SchoolType} {System.Environment.NewLine} Pais: {Country}, Ciudad:{City}";
        }
    }
}
