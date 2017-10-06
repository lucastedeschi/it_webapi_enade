using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iniciacao.Services.Questao
{
    public interface IQuestaoService
    {
        void InsertQuestao(Domain.Questao questao);
        Domain.Questao GetQuestaoById(int id);
        List<Domain.Questao> GetAll();
        List<Domain.Questao> GetQuestoesByTemaId(int temaId);
        List<Domain.Questao> GetQuestoesByAnoEnade(int anoEnade);
    }
}
