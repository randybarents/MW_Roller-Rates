using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.DTProcessors
{
    public class UserProcessor
    {
        DBAccess Access = new DBAccess();

        public void CreateUser(string email, string password, string displayname, string description)
        {
            DTModels.UserModel data = new DTModels.UserModel
            {
                Email = email,
                Password = password,
                DisplayName = displayname,
                Description = description
            };
            string sql = @"INSERT INTO user (Email, Password, DisplayName, Description)
                            VALUES(@Email, @Password, @DisplayName, @Description);";
            Access.SaveData(sql, data);
        }
        
    }
}
