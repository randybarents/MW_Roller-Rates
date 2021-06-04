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
    public class ReviewProcessor
    {
        public string GetConnectionString()
        {
            return "Server=studmysql01.fhict.local;Uid=dbi365190;Database=dbi365190;Pwd=MySQLPass123@;";
        }

        public void PlaceReview(string text , int rating , int userID , int rollercoasterID)
        {
            ReviewDTO data = new ReviewDTO
            {
                Text = text,
                Rating = rating,
                User_ID = userID,
                Rollercoaster_ID = rollercoasterID
            };
            string sql = @"INSERT INTO review (Text, Rating, User_ID, Rollercoaster_ID)
                            VALUES(@Text, @Rating, @User_ID, @Rollercoaster_ID);";
            using (IDbConnection con = new MySqlConnection(GetConnectionString()))
            {
                con.Execute(sql, data);
            }
        }
    }
}
