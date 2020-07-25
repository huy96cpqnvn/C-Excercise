using QualityTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QualityTest.Controller;

namespace QualityTest
{
    class Program
    {
        public static void GenerateMenu()
        {
            List<Student> students = new List<Student>();
            StudentController stc = new StudentController();
            int choice;
            do
            {
                Console.WriteLine("----------------Menu-----------------");
                Console.WriteLine("1. Create New Student");
                Console.WriteLine("2. View list of Students");
                Console.WriteLine("3. Exit");
                Console.WriteLine("-------------------------------------");
                Console.Write("Enter your choice:");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Student st = stc.CreateStudent();
                        students.Add(st);
                        break;
                    case 2:
                        stc.PrintListStudent(students);
                        break;
                    default:
                        break;
                }
            } while (choice != 3);
        }
        static void Main(string[] args)
        {
            GenerateMenu();
        }
    }
}

