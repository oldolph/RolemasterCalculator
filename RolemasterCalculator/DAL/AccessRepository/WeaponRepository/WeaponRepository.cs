using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RolemasterCalculator.Models.BaseTypes;
using RolemasterCalculator.Models.Weapon;
using RolemasterCalculator.DAL.AccessRepository.Base;
using System.Data.OleDb;

namespace RolemasterCalculator.DAL.AccessRepository.WeaponRepository
{
    public class WeaponRepository : IWeaponRepository
    {
        public IList<TypeDetail> GetTypes()
        {
            BaseConnection conn = new BaseConnection();
            conn.Open();

            string sql = "SELECT Distinct DamageType.ID, DamageType.type, Max(DamageTable.Roll) as MaxRoll, Min(DamageTable.Roll) as MinRoll FROM DamageType LEFT JOIN DamageTable ON DamageTable.TypeID = DamageType.ID Group By DamageType.type, Damagetype.id Order By DamageType.Type";

            OleDbDataReader dr = conn.GetReader(sql);

            List<TypeDetail> type = new List<TypeDetail>();
            while (dr.Read())
            {
                type.Add(new TypeDetail(Convert.ToInt32(dr["ID"]), Convert.ToString(dr["Type"]), Common.Functions.GetIntValue(dr["MinRoll"]), Common.Functions.GetIntValue(dr["MaxRoll"])));
            }

            conn.Close();

            return type;
        }

        public string GetWeaponDamage(int modifierTotal, int armorType, int weaponType)
        {
            string val = "";
            BaseConnection conn = new BaseConnection();
            conn.Open();

            using (OleDbDataReader dr = conn.GetReader("Select * From DamageTable Where Roll = " + modifierTotal + " And TypeID = " + weaponType))
            {
                if (dr.Read())
                {
                    val = Convert.ToString(dr["AT" + armorType]);
                }
            }

            conn.Close();
            conn = null;

            return val;
        }
    }
}
