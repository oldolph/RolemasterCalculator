using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RolemasterCalculator.Models.Modifier;
using RolemasterCalculator.Models.BaseTypes;
using RolemasterCalculator.BLL.Weapon;

namespace RolemasterCalculator.BLL.Modifier
{
    public class ModifierController
    {
        private IList<ModifierDetail> _modifiers;

        public ModifierController()
        {
            _modifiers = new List<ModifierDetail>();
        }

        public void AddModifier(ModifierDetail md)
        {
            _modifiers.Add(md);
        }

        public void RemoveModifier(int index)
        {
            _modifiers.RemoveAt(index);
        }

        public void ClearModifiers()
        {
            _modifiers.Clear();
        }

        public int Count
        {
            get
            {
                return _modifiers.Count;
            }
        }

        public IList<ModifierDetail> GetModifiers()
        {
            return _modifiers;
        }

        public static int Calculate(ModifierController attackModifiers, ModifierController defenseModifiers, int attackRoll, int defenseBonus, int weaponType)
        {
            int modTotal = (attackModifiers - defenseModifiers) + (attackRoll - defenseBonus);

            IBaseType type = new WeaponController();
            TypeDetail td = type.GetType(weaponType);

            if (modTotal > td.RollMax)
            {
                modTotal = td.RollMax;
            }
            if (modTotal < td.RollMin)
            {
                modTotal = td.RollMin;
            }

            return modTotal;

        }

        public static int operator -(ModifierController attack, ModifierController defense)
        {
            int attackTotal = 0;

            foreach (ModifierDetail md in attack.GetModifiers())
            {
                attackTotal += md.Value;
            }

            int defenseTotal = 0;

            foreach (ModifierDetail md in defense.GetModifiers())
            {
                defenseTotal += md.Value;
            }

            int total = attackTotal - defenseTotal;

            return total;
        }
    }
}
