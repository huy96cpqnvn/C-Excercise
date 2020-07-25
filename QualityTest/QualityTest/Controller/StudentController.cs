﻿using QualityTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityTest.Controller
{
    class StudentController
    {
        public void PrintListStudent(List<Student> students)
        {
            foreach(Student st in students )
            {
                Console.WriteLine("RollNumber: ", st.RollNumber);
                Console.WriteLine("FullName: ", st.FullName);
                Console.WriteLine("Birthday: ", st.Birthday);
                Console.WriteLine("Email: ", st.Email);
                Console.WriteLine("Phone: ", st.Phone);
                Console.WriteLine("CreatedAt: ", st.CreatedAt);
                Console.WriteLine("Status: ", st.Status);
            }
        }

        public Student CreateStudent()
        {
            Student st = new Student();

            Console.WriteLine("Enter RollNumber:");
            st.RollNumber = Console.ReadLine();
            Console.WriteLine("Enter FullName:");
            st.FullName = Console.ReadLine();
            Console.WriteLine("Enter Birthday:");
            st.Birthday = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Email:");
            st.Email = Console.ReadLine();
            Console.WriteLine("Enter Phone:");
            st.Phone = Console.ReadLine();
            Console.WriteLine("Enter CreatedAt:");
            st.CreatedAt = Console.ReadLine();
            Console.WriteLine("Enter Status:");
            st.Status = Console.ReadLine();

            return st;
        }
    }
}
