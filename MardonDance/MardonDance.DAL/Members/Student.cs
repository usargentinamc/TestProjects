using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLCE;

namespace MardonDance.DAL
{
    public class Student : IMardonMember
    {
        private int fStudentID;
        public int StudentID
        {
            get { return fStudentID; }
            set { fStudentID = value; }
        }

        private Family fFamilyID;
        public Family FamilyID
        {
            get { return fFamilyID; }
            set { fFamilyID = value; }
        }

        #region IMardonMember implementaiton

        private string fFirstName;
        public string FirstName
        {
            get { return fFirstName; }
            set { fFirstName = value; }
        }

        private string fLastName;
        public string LastName
        {
            get { return fLastName; }
            set { fLastName = value; }
        }

        private int fAge;
        public int Age
        {
            get { return fAge; }
            set { fAge = value; }
        }

        private int fYearsOfExperience;
        public int YearsOfExperience
        {
            get { return fYearsOfExperience; }
            set { fYearsOfExperience = value; }
        }

        private int fYearsAtMardon;
        public int YearsAtMardon
        {
            get { return fYearsAtMardon; }
            set { fYearsAtMardon = value; }
        }

        private IMardonMember fReferredBy;
        public IMardonMember ReferredBy
        {
            get { return fReferredBy; }
            set { fReferredBy = value; }
        }

        #endregion
    }
}
