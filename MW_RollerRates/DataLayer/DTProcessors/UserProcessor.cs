using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Dapper;
using System.Linq;
using MySql.Data.MySqlClient;

namespace DataLayer.DTProcessors
{
    public class UserProcessor
    {
        public string GetConnectionString()
        {
            return "Server=studmysql01.fhict.local;Uid=dbi365190;Database=dbi365190;Pwd=MySQLPass123@;";
        }

        public void CreateUser(string email, string password, string displayname, string description)
        {
            DTModels.UserDTO data = new DTModels.UserDTO
            {
                Email = email,
                Password = password,
                DisplayName = displayname,
                Description = description
            };
            string sql = @"INSERT INTO user (Email, Password, DisplayName, Description)
                            VALUES(@Email, @Password, @DisplayName, @Description);";
            using (IDbConnection con = new MySqlConnection(GetConnectionString()))
            {
                con.Execute(sql, data);
            }
        }
        
    }
}
