using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iniciacao.Data;
using Iniciacao.Domain;
using Iniciacao.Services.Questao;

namespace Iniciacao.Services.Tema
{
    public class QuestaoService : IQuestaoService
    {
        private readonly IRepository<Domain.Questao> _repository;

        public QuestaoService(IRepository<Domain.Questao> repository)
        {
            _repository = repository;
        }

        public List<Domain.Questao> GetAll()
        {
            return _repository.GetAll().ToList();
        }

        public Domain.Questao GetQuestaoById(int id)
        {
            return _repository.GetById(id);
        }

        public List<Domain.Questao> GetQuestoesByAnoEnade(int anoEnade)
        {
            return _repository.GetAll().Where(x => x.EnadeAno == anoEnade).ToList();
        }

        public List<Domain.Questao> GetQuestoesByTemaId(int temaId)
        {
            return _repository.GetAll().Where(x => x.TemaId == temaId).ToList();
        }

        public void InsertQuestao(Domain.Questao questao)
        {
            _repository.Insert(questao);
        }
    }
}
