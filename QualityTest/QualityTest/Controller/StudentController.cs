using QualityTest.Models;
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
            foreach(var st in students )
            {
                Console.WriteLine("RollNumber: {0}", st.RollNumber);
                Console.WriteLine("FullName: {0}", st.FullName);
                Console.WriteLine("Birthday: {0}", st.Birthday);
                Console.WriteLine("Email: {0}", st.Email);
                Console.WriteLine("Phone: {0}", st.Phone);
                Console.WriteLine("CreatedAt: {0}", st.CreatedAt);
                Console.WriteLine("Status: {0}", st.Status);
            }
        }

        public Student CreateStudent()
        {
            Student st = new Student();

            Console.WriteLine("Enter RollNumber:");
            st.RollNumber = Console.ReadLine();
            Console.WriteLine("Enter FullName:");
            st.FullName = Console.ReadLine();
            Console.WriteLine("Enter Birthday (dd/mm/yyyy):");
            var bd = Console.ReadLine();
            st.Birthday = DateTime.Parse(bd);
            Console.WriteLine("Enter Email:");
            st.Email = Console.ReadLine();
            Console.WriteLine("Enter Phone:");
            st.Phone = Console.ReadLine();
            Console.WriteLine("Enter CreatedAt (dd/mm/yyyy):");
            var ca = Console.ReadLine();
            st.CreatedAt = DateTime.Parse(ca);
            Console.WriteLine("Enter Status:");
            Enum.TryParse("Deactive", out StudentStatus Status);

            return st;
        }
    }
}
