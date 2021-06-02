using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MW_RollerRates.Models
{
    public class ViewRollerCoasterModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Speed { get; set; }
        public int Length { get; set; }
        public int Height { get; set; }
    }
}
