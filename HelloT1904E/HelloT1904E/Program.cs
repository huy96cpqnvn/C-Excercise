using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloT1904E
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter student rollnumber: ");
            Student st = new Student();
            string rollNumber = Console.ReadLine();
            st.SetRollNumber(rollNumber);
            Console.WriteLine("student rollnumber" )
        }
    }
}
