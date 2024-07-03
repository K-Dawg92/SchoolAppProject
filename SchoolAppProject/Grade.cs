using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAppProject
{
    public class Grade
    {
        //Attributes of the class
        public double gradeScore { get; set; }
        public string appreciation { get; set; }

        public Course Course { get; set; }  
       

        //Constructor of the class
        public Grade(double gradeScore, string appreciation, Course course)
        {
            this.gradeScore = gradeScore;
            this.appreciation = appreciation;
            Course=course;
        }
    }
}
