using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPolymorphism
{
    class PAVETeacher : Teacher
    {
        public PAVETeacher(int pStaffID, string pFname, string pLname, string pGender) : base(pStaffID, pFname, pLname, pGender)
        {
            TeachBehaviour = new TeachPAVE();
        }

        public override string GetOccupation()
        {
            return "PAVE Teacher";
        }
    }
}
