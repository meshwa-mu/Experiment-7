
using System;
using System.ComponentModel.DataAnnotations;

namespace Experiment_7.Models
{
    public class Feedback
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter student name")]
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }

        [Required(ErrorMessage = "Enter enrollment number")]
        [Display(Name = "Enrollment Number")]
        public string EnrollmentNo { get; set; }

        [Required(ErrorMessage = "Enter email address")]
        [EmailAddress(ErrorMessage = "Enter a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Select a rating")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
        public int? Rating { get; set; }

        [Required(ErrorMessage = "Enter comments")]
        [StringLength(500)]
        public string Comments { get; set; }

        public DateTime SubmittedOn { get; set; }
    }
}