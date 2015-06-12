using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLCE;

namespace MardonDance.DAL.Administrative
{
    public class StaffTitle
    {
        private int fTitleID;
        public int TitleID
        {
            get { return fTitleID; }
            set { fTitleID = value; }
        }

        private string fName;
        public string Name
        {
            get { return fName; }
            set { fName = value; }
        }
    }
}
