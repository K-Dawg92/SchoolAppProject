using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAppProject
{
    public class Menu
    {
        private App app;

        public Menu(App app)
        {
            this.app = app;
        }

        public void DisplayMainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("{0,20}", "Main Menu");
                Console.WriteLine("1. Students");
                Console.WriteLine("2. Courses");
                Console.WriteLine("0. Exit");
                Console.WriteLine("{0,30}", "Please select an option");
                string choice = Console.ReadLine();



                switch (choice)
                {
                    case "1":
                        DisplayStudentMenu();
                        Console.ReadKey();
                        break;
                    case "2":
                        DisplayCourseMenu();
                        Console.ReadKey();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;

                }
            }


        }
        public void DisplayStudentMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("{0,50}", "STUDENT MENU");
                Console.WriteLine("1. List of Students");
                Console.WriteLine("2. Create a student");
                Console.WriteLine("3. Consult an existing student");
                Console.WriteLine("4. Add a grade and an assessment for a course on an existing student");
                Console.WriteLine("0. Revenir au menu principal");
                Console.WriteLine("Please select an option");
                string choice = Console.ReadLine();


                switch (choice)
                {
                    case "1":
                        app.DisplayListOfStudent();
                        Console.ReadKey();
                        break;
                    case "2":
                        app.CreateStudent();
                        Console.ReadKey();
                        break;
                    case "3":
                        app.ConsultStudent();
                        Console.ReadKey();
                        break;
                    case "4":
                        app.AddGrade();
                        Console.ReadKey();
                        break;
                    case "5":
                        return;
                    case "0":
                        DisplayMainMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again");
                        break;

                }
            }



        }
        public void DisplayCourseMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("COURSE MENU");
                Console.WriteLine("1. List existing courses");
                Console.WriteLine("2. Add a new course");
                Console.WriteLine("3. Delete a course");
                Console.WriteLine("0. Return to Main Menu");
                Console.WriteLine("Please select an option");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        app.DisplayListCourses();
                        Console.ReadKey();
                        break;
                    case "2":
                        app.AddCourse();
                        Console.ReadKey();
                        break;
                    case "3":
                        app.DeleteCourse();
                        Console.ReadKey();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again");
                        break;
                }
            }
        }
    }
}

