using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RolemasterCalculator.Models.BaseTypes;
using RolemasterCalculator.Models.Critical;
using RolemasterCalculator.DAL.AccessRepository.Base;
using System.Data.OleDb;

namespace RolemasterCalculator.DAL.AccessRepository.CriticalRepository
{
    public class CriticalRepository : ICriticalRepository
    {
        public IList<TypeDetail> GetTypes()
        {
            BaseConnection conn = new BaseConnection();
            conn.Open();

            string sql = "SELECT Distinct CriticalType.ID, CriticalType.CriticalType, Max(CriticalTable.Roll) as MaxRoll, Min(CriticalTable.Roll) as MinRoll FROM CriticalType LEFT JOIN CriticalTable ON CriticalTable.Type = CriticalType.ID Group By CriticalType.CriticalType, CriticalType.ID Order By CriticalType.CriticalType";

            OleDbDataReader dr = conn.GetReader(sql);

            List<TypeDetail> types = new List<TypeDetail>();
            while (dr.Read())
            {
                types.Add(new TypeDetail(Convert.ToInt32(dr["ID"]), Convert.ToString(dr["CriticalType"]), Common.Functions.GetIntValue(dr["MinRoll"]), Common.Functions.GetIntValue(dr["MaxRoll"])));
            }

            conn.Close();

            return types;
        }

        public string GetCritical(int roll, int critType, string severity)
        {
            string val = "";
            BaseConnection conn = new BaseConnection();
            conn.Open();

            using (OleDbDataReader dr = conn.GetReader("Select * From CriticalTable Where Roll = " + roll + " And Type = " + critType))
            {
                if (dr.Read())
                {
                    val = Convert.ToString(dr[severity]);
                }
            }

            conn.Close();
            conn = null;

            return val;
        }
    }
}
