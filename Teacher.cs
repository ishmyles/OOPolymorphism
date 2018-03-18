using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPolymorphism
{
    abstract class Teacher : Person
    {
        public int StaffID { get; }

        protected ITeach TeachBehaviour;

        public Teacher(int staffID, string pFname, string pLname, string pGender) : base(pFname, pLname, pGender)
        { }

        public override string GetOccupation()
        {
            return "Teacher";
        }

        public override string Work()
        {
            return TeachBehaviour.Teach();
        }
    }
}
