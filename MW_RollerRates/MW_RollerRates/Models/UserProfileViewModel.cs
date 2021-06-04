using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelLayer;

namespace MW_RollerRates.Models
{
    public class UserProfileViewModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public List<RollerCoasterDTO> RollerCoasters { get; set; }
    }
}
