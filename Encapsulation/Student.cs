using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class Student
    {
        public int Id
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }
        public int Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }



        public string SurName { get { return SurName; } set { SurName = value; } }
        public string Specialty { get { return Specialty; } set { Specialty = value; } }
    }
}
