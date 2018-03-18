using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPolymorphism
{
    class TeachSpecialNeeds : ITeach
    {
        public string Teach()
        {
            return "Teach Special Needs";
        }
    }
}
