using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;

namespace MardonDance.DAL
{
    public static class MardonDataAccess
    {
        public static string ConnectionString
        {
            get { return System.Configuration.ConfigurationManager.AppSettings["SQLConnectionString"]; }
        }
    }
}
