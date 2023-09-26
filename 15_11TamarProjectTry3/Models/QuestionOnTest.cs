using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _15_11TamarProjectTry3.Models
{
    public class QuestionOnTest
    {
        [Display(Name = "Qustion Number:")]
        public int Id { get; set; }
        [Display(Name = "Qustion:")]
        public string Question { get; set; }
        public string CorrectAnswer { get; set; }
        public string SecondCorrectAnswer { get; set; }
        [Display(Name = "Verb To Change:")]
        public string VerbToChange { get; set; }
        [Display(Name = "Second Verb To Change:")]
        public string SecondVerbToChange { get; set; }
        public virtual List<QuizResult> QuizResult { get; set; }

    }
}
