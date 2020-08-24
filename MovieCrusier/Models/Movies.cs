using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MovieCrusier.Models
{
    public partial class Movies
    {
        public int MovieId { get; set; }

        [Required(ErrorMessage ="Please enter movie ")]
        [StringLength(maximumLength: 20, MinimumLength = 4, ErrorMessage = "Name should between 4 to 20 characters")]
        public string MovieName { get; set; }
        [Required(ErrorMessage ="Please enter BoxOffice range")]
        public string BoxOffice { get; set; }
        [Required(ErrorMessage ="Select Yes or No")]

        public string Active { get; set; }
        [Required(ErrorMessage ="Please select Genre")]
        public string Genre { get; set; }
        [Required(ErrorMessage = "Please select HasTeaser")]
        public string HasTeaser { get; set; }
        [Required(ErrorMessage = "Date is Required")]
        public DateTime DateOfLaunch { get; set; }
    }
}
