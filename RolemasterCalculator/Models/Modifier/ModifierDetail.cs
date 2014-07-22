using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RolemasterCalculator.Models.Modifier
{
    public class ModifierDetail
    {
        public int Value { get; set; }
        public string Description { get; set; }

        public ModifierDetail(int value, string description)
        {
            Value = value;
            Description = description;
        }
    }
}
