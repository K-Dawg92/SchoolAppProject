using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAppProject
{
    // Properties of the class Course
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // constructor of the class Course
        public Course(int _id, string _name ) 
        {
            Id = _id;
            Name = _name;
        }

    }

}
