using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RolemasterCalculator.Models.BaseTypes
{
    public interface IBaseType
    {
        IList<TypeDetail> GetTypes();
        TypeDetail GetType(int id);
    }
}
