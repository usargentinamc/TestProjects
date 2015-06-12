using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MardonDance.DAL
{
    public class ContactCard
    {
        private int fContactCardID;
        public int ContactCardID
        {
            get { return fContactCardID; }
            set { fContactCardID = value; }
        }

        private IMardonMember fMember;
        public IMardonMember Member
        {
            get { return fMember; }
            set { fMember = value; }
        }

        private ContactTypeEnum fRelationship;
        public ContactTypeEnum Relationship
        {
            get { return fRelationship; }
            set { fRelationship = value; }
        }

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

        private string fAddress1;
        public string Address1
        {
            get { return fAddress1; }
            set { fAddress1 = value; }
        }

        private string fAddress2;
        public string Address2
        {
            get { return fAddress2; }
            set { fAddress2 = value; }
        }

        private string fAddressCity;
        public string AddressCity
        {
            get { return fAddressCity; }
            set { fAddressCity = value; }
        }

        private string fAddressState;
        public string AddressState
        {
            get { return fAddressState; }
            set { fAddressState = value; }
        }

        private string fAddressZip;
        public string AddressZip
        {
            get { return fAddressZip; }
            set { fAddressZip = value; }
        }

        private string fPrimaryPhoneNumber;
        public string PrimaryPhoneNumber
        {
            get { return fPrimaryPhoneNumber; }
            set { fPrimaryPhoneNumber = value; }
        }

        private string fSecondaryPhoneNumber;
        public string SecondaryPhoneNumber
        {
            get { return fSecondaryPhoneNumber; }
            set { fSecondaryPhoneNumber = value; }
        }

        private string fEmailAddress;
        public string EmailAddress
        {
            get { return fEmailAddress; }
            set { fEmailAddress = value; }
        }
    }
}
