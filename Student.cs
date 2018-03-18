using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPolymorphism
{
    class Student : Person
    {
        public string StudentID { get; }

        public Student(string pStudentId, string pFname, string pLname, string pGender) : base(pFname, pLname, pGender)
        { }

        public override string Work()
        {
            return "Studying";
        }
    }
}
