using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.DTModels
{
    public class UserDTO
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
    }
}
