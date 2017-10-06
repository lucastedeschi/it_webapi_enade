using Iniciacao.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iniciacao.Services
{
    public interface IQuestionarioQuestaoService
    {
        void Insert(QuestionarioQuestao questionarioQuestao);
        QuestionarioQuestao GetById(long id);
        IEnumerable<QuestionarioQuestao> GetAll();
        void Update(QuestionarioQuestao questionarioQuestao);
        void Delete(QuestionarioQuestao questionarioQuestao);
    }
}
