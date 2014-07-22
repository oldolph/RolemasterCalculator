using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RolemasterCalculator.Common
{
    public static class Functions
    {
        public static int GetIntValue(object val)
        {
            if (string.IsNullOrEmpty(Convert.ToString(val)))
            {
                return 0;
            }
            else
            {
                int rtn;
                bool b = int.TryParse(Convert.ToString(val), out rtn);
                if (b)
                {
                    return rtn;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
