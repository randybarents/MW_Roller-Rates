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
    public class UserProcessor
    {
        public string GetConnectionString()
        {
            return "Server=studmysql01.fhict.local;Uid=dbi365190;Database=dbi365190;Pwd=MySQLPass123@;";
        }

        public void CreateUser(string email, string password, string displayname, string description)
        {
            string salt = PasswordHashing.GenerateSalt();
            string hash = PasswordHashing.GeneratePasswordHash(password, salt);
            UserDTO data = new UserDTO
            {
                Email = email,
                Salt = salt,
                PasswordHash = hash,
                DisplayName = displayname,
                Description = description
            };
            string sql = @"INSERT INTO user (Email, Salt, PasswordHash, DisplayName, Description)
                            VALUES(@Email, @Salt, @PasswordHash, @DisplayName, @Description);";
            using (IDbConnection con = new MySqlConnection(GetConnectionString()))
            {
                con.Execute(sql, data);
            }
        }
        
    }
}
