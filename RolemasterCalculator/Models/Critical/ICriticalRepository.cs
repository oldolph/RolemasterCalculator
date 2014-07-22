using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RolemasterCalculator.Models.BaseTypes;

namespace RolemasterCalculator.Models.Critical
{
    public interface ICriticalRepository : IBaseTypeRepository
    {
        string GetCritical(int roll, int critType, string severity);
    }
}
