using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace RolemasterCalculator.DAL.AccessRepository.Base
{
    public class BaseConnection
    {
        private OleDbConnection _conn;

        public void Open()
        {
            _conn = new OleDbConnection(string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};", ConnectionHelper.GetConnectionString));
            try
            {
                _conn.Open();
            }
            catch
            {
                throw;
            }
        }

        public void Close()
        {
            if (_conn != null)
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                    _conn = null;
                }
            }
        }

        public OleDbDataReader GetReader(string query)
        {
            OleDbDataReader dr;

            using (OleDbCommand cmd = new OleDbCommand())
            {
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }

            return dr;
        }

        public int Execute(string query)
        {
            int affected;

            using (OleDbCommand cmd = new OleDbCommand())
            {
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                affected = cmd.ExecuteNonQuery();
            }

            return affected;
        }
    }
}
