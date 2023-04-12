using AutoMapper;
using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class QuestionsService : IQuestionsService
    {
        private readonly IQuestionsRepository _repository;

        private readonly IMapper _mapper;

        public QuestionsService(IQuestionsRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Add(Question question)
        {
            _repository.Add(_mapper.Map<QuestionEntity>(question));
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<Question> GetQuestionsByUserId(int id)
        {
            List<QuestionEntity> questions = _repository.GetQuestionsByUserId(id);
            return _mapper.Map<List<Question>>(questions);
        }

        public void Update(Question question)
        {
            _repository.Update(_mapper.Map<QuestionEntity>(question));
        }
    }
}
