using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLCE;

namespace MardonDance.DAL.Dance
{
    public class Style
    {
        private int fStyleID;
        public int StyleID
        {
            get { return fStyleID; }
            set { fStyleID = value; }
        }        
        
        private string fName;
        public string Name
        {
            get { return fName; }
            set { fName = value; }
        }
    }
}
