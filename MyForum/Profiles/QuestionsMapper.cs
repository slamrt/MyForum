using AutoMapper;
using Models;

namespace MyForum.Profiles
{
    public class QuestionsMapper: Profile
    {
        public QuestionsMapper()
        {
            CreateMap<QuestionEntity, Question>().ReverseMap();
        }
    }
}
