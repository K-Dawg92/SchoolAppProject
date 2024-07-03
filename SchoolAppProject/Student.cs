using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAppProject
{
    public class Student
    {
        // these are the attributes of the class student
        public  string Surname { get; set; }
        public  string FirstName { get; set; }
        public  int studentId { get; set; }
        public  DateTime DOB { get; set; }
        public List<Grade> Grades { get; set; }

        // Constructor of the class Student
        public Student(string _surname, string _firstName, int _studentId, DateTime _DOB)
        {
            Surname = _surname;
            FirstName = _firstName;
            studentId = _studentId;
            Grades = new List<Grade>();
            DOB = _DOB;

            
        }
        
      

    }
}
