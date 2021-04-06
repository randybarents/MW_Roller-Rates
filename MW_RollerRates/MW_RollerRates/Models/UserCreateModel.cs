using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MW_RollerRates.Models
{
    public class UserCreateModel
    {
        public int Id { get; set; }

        [Display(Name = "E-Mail")]
        [Required(ErrorMessage = "Enter an e-mail address")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Enter a valid e-mail address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Confirm e-mail")]
        [Display(Name = "Confirm e-mail")]
        [Compare("Email", ErrorMessage = "E-mail must match the above.")]
        public string ConfirmEmail { get; set; }

        [Required(ErrorMessage = "Enter a password")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Password has to be a minimum of 5 characters and a maximum of 15")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm password")]
        [Display(Name = "Confirm password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password must match the above.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Enter a name for your profile!")]
        [Display(Name = "DisplayName")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Name must be at least 2 characters")]
        public string DisplayName { get; set; }

        [Required(ErrorMessage = "Enter a description for your profile!")]
        [Display(Name = "Description")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Description must be at least 2 characters")]
        public string Description { get; set; }
    }
}
