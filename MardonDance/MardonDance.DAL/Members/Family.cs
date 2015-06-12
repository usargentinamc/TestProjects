using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLCE;
using MardonDance.DAL.Administrative;

namespace MardonDance.DAL
{
    public class Family
    {
        public Family() { }

        private int fFamiliyID;
        public int FamiliyID
        {
            get { return fFamiliyID; }
            set { fFamiliyID = value; }
        }

        private ContactCard fMothersContactCard;
        public ContactCard MothersContactCard
        {
            get { return fMothersContactCard; }
            set { fMothersContactCard = value; }
        }

        private ContactCard fFathersContactCard;
        public ContactCard FathersContactCard
        {
            get { return fFathersContactCard; }
            set { fFathersContactCard = value; }
        }

        private List<Student> fStudents;
        public List<Student> Students
        {
            get { return fStudents; }
            set { fStudents = value; }
        }

        private List<StaffMember> fStaffMembers;
        public List<StaffMember> StaffMembers
        {
            get { return fStaffMembers; }
            set { fStaffMembers = value; }
        }
    }
}
