using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _15_11TamarProjectTry3.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Display(Name = "Enter your code")]
        [Required(ErrorMessage = "Please enter a number.")]
        [Range(699, 802)]
        public int? MyId { get; set; }
        [Display(Name = "First Name:")]
        [Required(ErrorMessage = "Please enter a first name.")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name:")]
        [Required(ErrorMessage = "Please enter a last name.")]
        public string LastName { get; set; }
        public virtual List<QuizResult> StudentsQuestionInfo { get; set; }
    }
}

