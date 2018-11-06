using System.Collections;
using System.ComponentModel.DataAnnotations;


namespace MvcMovie.Models
{
    public class Review
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3, ErrorMessage = "Must be at least 3 characters")]
        [Required]
        public string ReviewMaker { get; set; }

        [StringLength(1500, MinimumLength = 10, ErrorMessage = "Review must have at least 10 characters.")]
        [Required]
        public string UserReview { get; set; }

        [Required]
        public int MovieID { get; set; }

        [Required]
        public string MovieTitle { get; set; }
    }

}