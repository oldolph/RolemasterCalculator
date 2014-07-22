using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RolemasterCalculator.Models.Weapon;
using RolemasterCalculator.DAL.AccessRepository.WeaponRepository;
using RolemasterCalculator.Models.BaseTypes;

namespace RolemasterCalculator.BLL.Weapon
{
    public class WeaponController : IBaseType
    {
        private IWeaponRepository _weaponRepository;

        public WeaponController() : this(new WeaponRepository()) { }

        public WeaponController(IWeaponRepository weaponRepository)
        {
            _weaponRepository = weaponRepository;
        }

        public IList<TypeDetail> GetTypes()
        {
            return _weaponRepository.GetTypes().ToList();
        }

        public TypeDetail GetType(int id)
        {
            return _weaponRepository.GetTypes().SingleOrDefault(x=> x.ID == id);
        }

        public string GetWeaponDamage(int modifierTotal, int armorType, int weaponType)
        {
            return _weaponRepository.GetWeaponDamage(modifierTotal, armorType, weaponType);
        }
    }
}
