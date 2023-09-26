using _15_11TamarProjectTry3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _15_11TamarProjectTry3.Repositories
{
    public interface IRepository
    {
        void GetRandomOrder();
        QuestionOnTest GetNextQuestion(out int questionNumber);
        void SaveUser(Student student);
        void SaveStudentQuestionResult(QuizResult quizResult);
        Student GetStudent();
        Student FindUserInDb(Student student);
    }
}
