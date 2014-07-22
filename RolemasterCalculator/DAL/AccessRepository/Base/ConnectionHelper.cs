using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RolemasterCalculator.DAL.AccessRepository.Base
{
    public static class ConnectionHelper
    {
        public static string GetConnectionString
        {
            get
            {
                return string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};", Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\RoleMasterDamageCalc.mdb");
            }
        }
    }
}
