using Microsoft.AspNetCore.Mvc;
using Models;
using Newtonsoft.Json.Bson;
using Services;

namespace MyForum.Controllers
{
    [Route("Questions")]
    public class QuestionsController : Controller
    {
        private readonly IQuestionsService _service;

        public QuestionsController(IQuestionsService service)
        {
            _service = service;
        }

        [HttpGet("{userId:int}")]
        public List<Question> GetQuestionsByUserId(int userId)
        {
            List<Question> res =  _service.GetQuestionsByUserId(userId);
            return res;
        }

        [HttpPost]
        public void Add([FromBody] Question newQuestion)
        {
            _service.Add(newQuestion);
        }

        [HttpPut]

        public void Update([FromBody] Question Question)
        {
            _service.Update(Question);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
