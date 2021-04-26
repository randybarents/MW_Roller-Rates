using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Dapper;
using System.Linq;
using MySql.Data.MySqlClient;
using ModelLayer;

namespace DataLayer.DTProcessors
{
    public class RollerCoasterProcessor
    {
        public string GetConnectionString()
        {
            return "Server=studmysql01.fhict.local;Uid=dbi365190;Database=dbi365190;Pwd=MySQLPass123@;";
        }

        public List<RollerCoasterDTO> LoadRollerCoasters()
        {
            string sql = "SELECT * FROM item";
            using (IDbConnection con = new MySqlConnection(GetConnectionString()))
            {
                return con.Query<RollerCoasterDTO>(sql).ToList();
            }
        }
    }
}
