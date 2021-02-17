using System;
using System.ComponentModel.DataAnnotations;
using DojoSurveyModel.Controllers;

namespace DojoSurveyModel.Models
{
    public class Survey
    {
        [Required(ErrorMessage="Name Required")]
        [MinLength(2, ErrorMessage="Name must be longer than 2 characters")]
        [Display(Name = "Your Name:")]
        public string Name { get; set; }

        [Required(ErrorMessage="Location Required")]
        [Display(Name = "Dojo Location:")]
        public string Location { get; set; }

        [Required(ErrorMessage="Language Required")]
        [Display(Name = "Favorite Language:")]
        public string Language { get; set; }

        [MaxLength(20, ErrorMessage="Comments should be no more than 20 characters")]
        [Display(Name = "Comments (optional):")]
        public string Comment { get; set; }

    }
}