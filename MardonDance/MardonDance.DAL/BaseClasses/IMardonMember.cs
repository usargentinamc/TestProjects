using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLCE;

namespace MardonDance.DAL
{
    public interface IMardonMember
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
        int YearsOfExperience { get; set; }
        int YearsAtMardon { get; set; }
        IMardonMember ReferredBy { get; set; }
    }
}
