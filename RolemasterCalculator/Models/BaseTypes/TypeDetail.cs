using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RolemasterCalculator.Models.BaseTypes
{
    public class TypeDetail
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public int RollMax { get; set; }
        public int RollMin { get; set; }

        public TypeDetail(int id, string type, int rollMin, int rollMax)
        {
            ID = id;
            Type = type;
            RollMax = rollMax;
            RollMin = rollMin;
        }
    }
}
