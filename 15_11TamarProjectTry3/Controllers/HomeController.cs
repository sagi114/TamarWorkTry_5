using _15_11TamarProjectTry3.Models;
using _15_11TamarProjectTry3.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace _15_11TamarProjectTry3.Controllers
{
    public class HomeController : Controller
    {
        IRepository _repository;
        public HomeController(IRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            _repository.GetRandomOrder();
            ViewBag.isValid = true;
            return View();
        }
        public IActionResult SaveStudentInformation(Student student)
        {
            if (ModelState.IsValid)
            {
                _repository.SaveUser(student);
                return View();
            }
            else
            {
                ViewBag.isValid = false;
                return View("Index");
            }

        }
        public IActionResult Test(QuizResult quizResult=null/*, int id = -1*/)
        {
            if(quizResult.AnswerOne!=null)
            {
                _repository.SaveStudentQuestionResult(quizResult);
            }
            var q=_repository.GetNextQuestion(out int QuestionNumber);
            var s = _repository.GetStudent();
            if(q==null /*|| id == -1*/)
            {
                return View("End",s);
            }
            QuizResult qz = new QuizResult() { QuestionOnTest = q, QuestionOnTestId = q.Id, Student = s, StudentId = s.Id };
            ViewBag.QuestionNumber = QuestionNumber;
            return View(qz);
        }
    }
}