using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IQuestionsService
    {
        List<Question> GetQuestionsByUserId(int id);
        void Add(Question question);
        void Delete(int id);
        void Update(Question question);
    }
}
