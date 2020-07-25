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
        public void GenerateMenu()
        {
                Console.WriteLine("----------------Menu-----------------");
                Console.WriteLine("1. Create New Student");
                Console.WriteLine("2. View list of Students");
                Console.WriteLine("3. Exit");

        }
        static void Main(string[] args)
        {

            ///DateTime day1 = DateTime.Now;
            ///DateTime day2 = DateTime.Now.AddDays(-1);
            ///DateTime.Compare(day1, day2); //Trả về 3 giá trị, nếu day1 > day2 trả về 1, ngược lại là -1, giống nhau trả về 0
            ///Console.ReadLine();

            ///DateTime join = DateTime.Now.AddDays(-10);
            ///DateTime twoago = DateTime.Now.AddMonths(-2);

            ///Console.WriteLine((int)StudentStatus.Deactive);
            ///Console.ReadLine();

            List<Student> listStudent = new List<Student>();
            int choice = 0;
            do
            {
                listStudent.GenerateMenu();

                Console.Write("Enter your choice:");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Student n = new Student();
                        n.CreateStudent();
                        listStudent.Add(n);
                        break;

                    case 2:
                        PrintListStudent(listStudent);
                        break;
                    default:
                        break;
                }

            } while (choice != 3);
        }

    }
    }

