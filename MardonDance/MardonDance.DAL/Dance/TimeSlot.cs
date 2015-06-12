using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLCE;

namespace MardonDance.DAL.Dance
{
    public class TimeSlot
    {
        private int fTimeSlotID;
        public int TimeSlotID
        {
            get { return fTimeSlotID; }
            set { fTimeSlotID = value; }
        }

        private DayOfWeek fDayOfWeek;
        public DayOfWeek DayOfWeek
        {
            get { return fDayOfWeek; }
            set { fDayOfWeek = value; }
        }

        private TimeSpan fTime;
        public TimeSpan Time
        {
            get { return fTime; }
            set { fTime = value; }
        }
    }
}
