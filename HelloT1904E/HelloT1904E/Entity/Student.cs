using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloT1904E.Entity
{
    public class Student
    {
        private string _rollNumber;
        private string _email;
        private string _fullName;
        private string _age;
        
        public string GetRollNumber()
        {
            return this._rollNumber;
        }

        public void SetRollNumber(string rollNumber)
        {
            this._rollNumber = rollNumber;
        }

    }
}
