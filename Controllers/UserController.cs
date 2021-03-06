using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuizApp.Models;
using QuizApp.Data;
using QuizApp.Dtos;

namespace QuizApp.Controllers
{
    [Route("quizapi")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IQuizAPIRepo _repository;

        public UserController(IQuizAPIRepo repository)
        {
            _repository = repository;
        }


    }
}