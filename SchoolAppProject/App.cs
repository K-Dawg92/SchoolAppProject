using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAppProject
{
    public class App
    {       // Defines the properties to be able to store the students and courses
        List<Student> students { get; set; }
        List<Course> courses { get; set; }
        public App()
        {   // this is the constructor which is type of method to initiate (add value) both lists
            students = new List<Student>();
            courses = new List<Course>();
        }

        // method used to list the students
        public void DisplayListOfStudent()
        {
            Console.WriteLine("List of Students");
            foreach (Student student in students)
            {
                Console.WriteLine("index :{0,5}. First Name: {1,-10} Last Name: {2,-20} ", students.IndexOf(student), student.FirstName, student.Surname);
            }
            Console.WriteLine("Enter any key to return to previous menu");
        }
        // Method to list courses
        public void DisplayListCourses()
        {
            Console.WriteLine("List of current Courses");
            foreach (Course course in courses)
            {
                Console.WriteLine("Index : {0,5}. Course Name: {1,-10}", courses.IndexOf(course), course.Name);
            }
            Console.WriteLine("Enter any key to return to previous menu");
        }
        // method to create student
        public void CreateStudent()
        {
            Console.WriteLine("Enter student surname");
            string surName = Console.ReadLine();
            Console.WriteLine("Enter student first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the date of birth of student");
            DateTime DOB = DateTime.Parse(Console.ReadLine());
            int studentId = students.Count + 1; // you need to take the Id of the last student and add 1.
            students.Add(new Student(surName, firstName, studentId, DOB));
            Console.WriteLine("You have successfully added a new Student");
            Console.WriteLine("Please enter any key to return to previous menu");
        }
        // method to add course
        public void AddCourse()
        {
            Console.WriteLine("Enter course name");
            string courseName = Console.ReadLine();
            int courseId = courses.Count + 1; //you need to take the Id of the last course and add 1.
            courses.Add(new Course(courseId, courseName));
            Console.WriteLine("You have successfully added a new course");
            Console.WriteLine("Please enter any key to return to previous menu");

        }

        // method to delete course
        public void DeleteCourse()
        {
            Console.WriteLine("Enter course ID");
            int courseId = Convert.ToInt32(Console.ReadLine());
            Course course2Delete = courses.Find(c => c.Id == courseId);// c = Lambda expression which is seen as a foreach and will look for objects within the class
            courses.Remove(course2Delete);

            foreach (Student student in students)
            {
                student.Grades.RemoveAll(g => g.Course.Id == courseId);
            }
            Console.WriteLine($"{course2Delete.Name} has now been deleted");


        }
        public void ConsultStudent()
        {
            Console.WriteLine("Enter the surname or ID of student");
            string input = Console.ReadLine();
            Student student = null;
            if (int.TryParse(input, out int id)) //checks if the input can be converted into an integer
            {
                student = FindStudentId(id);
            }
            else
            {
                student = FindStudentSurname(input);
            }
            if (student != null) // if student is found
            {
                Console.WriteLine($"First Name: {student.FirstName}, Last Name: {student.Surname},  Date Of Birth: {student.DOB}, Student ID: {student.studentId}");
                Console.WriteLine("Grades:");
                foreach (var grade in student.Grades)
                {
                    Console.WriteLine($"Course: {grade.Course}, Grade: {grade.gradeScore}, Assessment: {grade.appreciation}");
                }
            }
            else
            {

            }
            {
                Console.WriteLine("Student not found");
            }


        }
        public Student FindStudentId(int ID)
        {
            return students.Find(Student => Student.studentId == ID);
        }
        public Student FindStudentSurname(string surName)
        {
            return students.Find(Student => Student.Surname == surName);
        }
        public void AddGrade()
        {
            Console.Clear();
            Console.WriteLine("Select student");
            DisplayListOfStudent();
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{i}. {students[i].FirstName}, {students[i].Surname}");
            }
            int studentSelectedIndex = Convert.ToInt32(Console.ReadLine());


        }


    }
}


