using System.Runtime;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace SchoolAppProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
           App app = new App(); // create an instance(object) of the class first before you can access the class App.
           Menu menu = new Menu(app);// by creating an instance of the class Menu, it will allow me to 

            menu.DisplayMainMenu();
                
                

            
            
            



        }
    }
}
