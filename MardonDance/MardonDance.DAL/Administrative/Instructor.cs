using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLCE;
using MardonDance.DAL.Dance;

namespace MardonDance.DAL.Administrative
{
    public class Instructor : StaffMember
    {
        private List<Class> fClasses;
        public List<Class> Classes
        {
            get { return fClasses; }
            set { fClasses = value; }
        }   

    }
}
