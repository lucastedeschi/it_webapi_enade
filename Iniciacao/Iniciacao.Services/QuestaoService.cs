using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iniciacao.Domain;
using Iniciacao.Data;

namespace Iniciacao.Services
{
    public class QuestaoService : IQuestaoService
    {
        private readonly IRepository<Questao> _questaoRepository;

        public QuestaoService(IRepository<Questao> questaoRepository)
        {
            _questaoRepository = questaoRepository;
        }

        public void Delete(Questao questao)
        {
            _questaoRepository.Delete(questao);
        }

        public IEnumerable<Questao> GetAll()
        {
            return _questaoRepository.GetAll();
        }

        public Questao GetById(long id)
        {
            return _questaoRepository.GetById(id);
        }

        public void Insert(Questao questao)
        {
            _questaoRepository.Insert(questao);
        }

        public void Update(Questao questao)
        {
            _questaoRepository.Update(questao);
        }
    }
}
