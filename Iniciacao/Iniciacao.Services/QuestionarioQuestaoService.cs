using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iniciacao.Domain;
using Iniciacao.Data;

namespace Iniciacao.Services
{
    public class QuestionarioQuestaoService : IQuestionarioQuestaoService
    {
        private readonly IRepository<QuestionarioQuestao> _questionarioQuestaoRepository;

        public QuestionarioQuestaoService(IRepository<QuestionarioQuestao> questionarioQuestaoRepository)
        {
            _questionarioQuestaoRepository = questionarioQuestaoRepository;
        }

        public void Delete(QuestionarioQuestao questionarioQuestao)
        {
            _questionarioQuestaoRepository.Delete(questionarioQuestao);
        }

        public IEnumerable<QuestionarioQuestao> GetAll()
        {
            return _questionarioQuestaoRepository.GetAll();
        }

        public QuestionarioQuestao GetById(long id)
        {
            return _questionarioQuestaoRepository.GetById(id);
        }

        public void Insert(QuestionarioQuestao questionarioQuestao)
        {
            _questionarioQuestaoRepository.Insert(questionarioQuestao);
        }

        public void Update(QuestionarioQuestao questionarioQuestao)
        {
            _questionarioQuestaoRepository.Update(questionarioQuestao);
        }
    }
}
