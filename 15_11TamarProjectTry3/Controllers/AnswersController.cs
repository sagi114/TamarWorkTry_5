using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _15_11TamarProjectTry3.Models;
using _15_11TamarProjectTry3.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace _15_11TamarProjectTry3.Controllers
{
    public class AnswersController : Controller
    {
        public IRepository _repository { get; set; }
        public AnswersController(IRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index(Student student)
        {
            var s = _repository.GetStudent();
            if(s==null&&student.MyId==null)
                return RedirectToAction("Register");
            if (student.MyId!=null)
            {
                s=_repository.FindUserInDb(student);
            }
            if (s == null) s = new Student() { FirstName = "", LastName = "", MyId = 801, StudentsQuestionInfo = new List<QuizResult>() };
            return View(s);
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}