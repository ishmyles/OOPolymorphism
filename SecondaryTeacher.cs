using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPolymorphism
{
    class SecondaryTeacher : Teacher
    {
        public SecondaryTeacher(int pStaffID, string pFname, string pLname, string pGender) : base(pStaffID, pFname, pLname, pGender)
        {
            TeachBehaviour = new TeachHighSchool();
        }

        public override string GetOccupation()
        {
            return "Secondary Teacher";
        }
    }
}
