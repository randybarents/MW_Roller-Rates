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
    public class UserRollerCoasterProcessor
    {
        public string GetConnectionString()
        {
            return "Server=studmysql01.fhict.local;Uid=dbi365190;Database=dbi365190;Pwd=MySQLPass123@;";
        }

        public void CheckinRollerCoaster(int userID , int rollercoasterID)
        {
            var data = new UserRollerCoastersDTO
            {
                User_ID = userID,
                RollerCoaster_ID = rollercoasterID
            };
            string sql = @"INSERT INTO user_checkins (User_ID , Rollercoaster_ID) VALUES(@User_ID , @RollerCoaster_ID);";
            using (IDbConnection con = new MySqlConnection(GetConnectionString()))
            {
                con.Execute(sql, data);
            }
        }

        public List<RollerCoasterDTO> LoadUserRollerCoasters(int UserID)
        {
            string sql = $"SELECT user.ID , rollercoaster.ID , rollercoaster.Name FROM user INNER JOIN user_checkins ON user.ID = '{UserID}' INNER JOIN rollercoaster on rollercoaster.ID = user_checkins.Rollercoaster_ID;";
            //string sql = $"SELECT * FROM user_checkins WHERE user_id = '{UserID}';"; 
            using (IDbConnection con = new MySqlConnection(GetConnectionString()))
            {
                return con.Query<RollerCoasterDTO>(sql).ToList();
            }
        }
    }
}
