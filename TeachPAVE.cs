﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPolymorphism
{
    class TeachPAVE : ITeach
    {
        public string Teach()
        {
            return "Teach Awesome SWD Students";
        }
    }
}
