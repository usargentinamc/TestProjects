using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLCE;
using MardonDance.DAL.Administrative;

namespace MardonDance.DAL.Dance
{
    public class Class
    {
        private int fClassID;
        public int ClassID
        {
            get { return fClassID; }
            set { fClassID = value; }
        }

        private Instructor fInstructorID;
        public Instructor InstructorID
        {
            get { return fInstructorID; }
            set { fInstructorID = value; }
        }

        private Style fStyleID;
        public Style StyleID
        {
            get { return fStyleID; }
            set { fStyleID = value; }
        }

        private TimeSlot fTimeSlotID;
        public TimeSlot TimeSlotID
        {
            get { return fTimeSlotID; }
            set { fTimeSlotID = value; }
        }
    }
}
