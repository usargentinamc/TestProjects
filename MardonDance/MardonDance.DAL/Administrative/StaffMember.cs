using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLCE;

namespace MardonDance.DAL.Administrative
{
    public class StaffMember : IMardonMember
    {
        private int fStaffID;
        public int StaffID
        {
            get { return fStaffID; }
            set { fStaffID = value; }
        }

        private Family fFamily;
        public Family Family
        {
            get { return fFamily; }
            set { fFamily = value; }
        }

        private StaffTitle fTitle;
        public StaffTitle Title
        {
            get { return fTitle; }
            set { fTitle = value; }
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
