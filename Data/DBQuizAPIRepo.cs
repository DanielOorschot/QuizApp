using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using QuizApp.Models;

namespace QuizApp.Data
{
    public class DBQuizAPIRepo : IQuizAPIRepo
    {
        private readonly QuizAPIDBContext _dbContext;

        public DBQuizAPIRepo(QuizAPIDBContext dbContext)
        {


