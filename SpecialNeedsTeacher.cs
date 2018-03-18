using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPolymorphism
{
    class SpecialNeedsTeacher : Teacher
    {
        public SpecialNeedsTeacher(int pStaffID, string pFname, string pLname, string pGender) : base(pStaffID, pFname, pLname, pGender)
        {
            TeachBehaviour = new TeachSpecialNeeds();
        }

        public override string GetOccupation()
        {
            return "Special Needs Teacher";
        }
    }
}
