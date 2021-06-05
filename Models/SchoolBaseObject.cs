using System;

namespace SchoolMVC.Models
{
    public abstract class SchoolBaseObject
    {
        public string UniqueId { get; set; }
        public string Name { get; set; }

        public SchoolBaseObject()
        {
            //UniqueId = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return $"{Name},{UniqueId}";
        }
    }
}