using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _15_11TamarProjectTry3.Models
{
    public class QuizResult
    {
        public int Id { get; set; }
        [Display(Name = "Student Id :")]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public int QuestionOnTestId { get; set; }
        public virtual QuestionOnTest QuestionOnTest{ get; set; }
        [Display(Name = "Answer To Question:")]
        public string AnswerOne { get; set; }
        [Display(Name = "Second Answer To Question:")]
        public string AnswerTwo { get; set; }
        public TimeSpan Time { get; set; }

    }
}
