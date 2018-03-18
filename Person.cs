using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPolymorphism
{
    abstract class Person
    {
        private string _gender;

        public string Fname { get; }
        public string Lname { get; }

        public Person(string pGender)
        {
            _gender = pGender;
        }

        public Person(string pFname, string pLname, string pGender)
        {
            Fname = pFname;
            Lname = pLname;

            if (pGender == "M")
                _gender = "Male";
            else if (pGender == "F")
                _gender = "Female";
            else
                throw new Exception("Incorrect format, please try again!");
        }

        public string GetGender()
        {
            return _gender;
        }

        public virtual string GetOccupation()
        {
            return "Unemployed";
        }

        public abstract string Work();
    }
}
