using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RolemasterCalculator.Models.BaseTypes
{
    public interface IBaseTypeRepository
    {
        IList<TypeDetail> GetTypes();
    }
}
