using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MW_RollerRates.Models
{
    public class PlaceReviewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You must enter a review description")]
        [Display(Name = "Description")]
        [StringLength(500, MinimumLength = 10, ErrorMessage = "Description must be at least 10 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage = "You must enter a rating")]
        [Display(Name = "Rating")]
        [Range(1 , 5 , ErrorMessage = "Rating must be between 1 and 5")]
        public int Rating { get; set; }
        
        public int User_ID { get; set; }
        public int Rollercoaster_ID { get; set; }
    }
}
