using _15_11TamarProjectTry3.DB;
using _15_11TamarProjectTry3.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace _15_11TamarProjectTry3.Repositories
{
    public class MyRepository:IRepository
    {
        StudentsTestResultContext _context;
        Random _rand = new Random();
        static int[] _randomOrderOfQuestion;
        static int _counterOfQuestionInQuiz=1;
        static int? _studentId;
        static int _questionId;
        static DateTime _startTime;
        static DateTime _endTime;
        public MyRepository(StudentsTestResultContext context)
        {
            _context = context;
        }
        public void GetRandomOrder()
        {
            int num;
            int counter = 1;
            bool[] CheckIfIndexWasLottery = new bool[_context.QuestionOnTests.Count()+1];
            int[] GetOrderOfRandomIndex = new int[_context.QuestionOnTests.Count()+1];
            CheckIfIndexWasLottery[0] = true;
            while (CheckIfIndexWasLottery.Any(a => a == false))
            {
                num = _rand.Next(_context.QuestionOnTests.Count()+1);
                if (CheckIfIndexWasLottery[num] == true) continue;
                else
                {
                    CheckIfIndexWasLottery[num] = true;
                    GetOrderOfRandomIndex[counter++] = num;
                }
            }
            _randomOrderOfQuestion=GetOrderOfRandomIndex;
        }
        public QuestionOnTest GetNextQuestion(out int questionNumber)
        {
            _startTime = DateTime.Now;
            questionNumber = _counterOfQuestionInQuiz;
            if (_counterOfQuestionInQuiz > 82) return null;
            var item = _context.QuestionOnTests.FirstOrDefault(q => q.Id == _randomOrderOfQuestion[_counterOfQuestionInQuiz]);
            _counterOfQuestionInQuiz++;
            _questionId = item.Id;
            return item;
        }
        public void SaveUser(Student student)
        {
            
            _context.Students.Add(new Student() { MyId=student.MyId,FirstName=student.FirstName,LastName=student.LastName});
            _context.SaveChanges();
            _studentId = _context.Students.FirstOrDefault(s => s.MyId == student.MyId && s.FirstName == student.FirstName && s.LastName == student.LastName).Id;
        }
        public Student FindUserInDb(Student student)
        {
            var s =_context.Students.FirstOrDefault(s => s.MyId == student.MyId && s.FirstName == student.FirstName && s.LastName == student.LastName);
            if (s == null) return s;
            _studentId = s.Id;
            return s;
        }
        public void SaveStudentQuestionResult(QuizResult quizResult)
        {
            _endTime = DateTime.Now;
            var t =  _endTime-_startTime;
            var s = _context.Students.FirstOrDefault(s => s.Id == _studentId);
            var q = _context.QuestionOnTests.FirstOrDefault(q => q.Id == _questionId);

            char[] charsToTrim = { '*', ' ', '\'' };
            if (quizResult.AnswerOne.StartsWith(' ') || quizResult.AnswerOne.EndsWith(' '))
            {
                quizResult.AnswerOne = quizResult.AnswerOne.Trim();
            }
            if (quizResult.AnswerOne.StartsWith(' ') || quizResult.AnswerOne.EndsWith(' '))
            {
                quizResult.AnswerTwo = quizResult.AnswerTwo.Trim();
            }


            _context.QuizResults.Add(new QuizResult(){ QuestionOnTest=q,QuestionOnTestId=_questionId, Student = s,StudentId = s.Id,AnswerOne=quizResult.AnswerOne,AnswerTwo=quizResult.AnswerTwo,Time=t});
            _context.SaveChanges();
        }
        public Student GetStudent()
        {
            /*var s=*/return  _context.Students.FirstOrDefault(s => s.Id == _studentId);
            //var qr = _context.QuizResults.Where(qr => qr.StudentId == _studentId);
            //if(s!=null)s.StudentsQuestionInfo = qr.ToList();
            //return s;
        }
    }
}
