using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class QuestionsRepository : IQuestionsRepository
    {
        private readonly DatabaseContext _context;

        public QuestionsRepository(DatabaseContext context) 
        { 
            _context = context; 
        }

        public void Add(QuestionEntity question)
        {
            _context.Questions.Add(question);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var questionToDelete = _context.Questions.FirstOrDefault(x => x.Id == id);
            _context.Questions.Remove(questionToDelete);
            _context.SaveChanges();
        }

        public List<QuestionEntity> GetQuestionsByUserId(int id)
        {
            List<QuestionEntity> questions = _context.Questions.Where(q => q.UserId == id).ToList();
            return questions;
        }

        public void Update(QuestionEntity question)
        {
            _context.Questions.Update(question);
            _context.SaveChanges();
        }
    }
}
