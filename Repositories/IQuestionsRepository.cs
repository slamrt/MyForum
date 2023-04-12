using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IQuestionsRepository
    {
        List<QuestionEntity> GetQuestionsByUserId(int id);
        void Update(QuestionEntity question);
        void Add(QuestionEntity question);
        void Delete(int id);
    }
}
