using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RolemasterCalculator.Models.BaseTypes;

namespace RolemasterCalculator.Models.Weapon
{
    public interface IWeaponRepository : IBaseTypeRepository
    {
        string GetWeaponDamage(int modifierTotal, int armorType, int weaponType);
    }
}
