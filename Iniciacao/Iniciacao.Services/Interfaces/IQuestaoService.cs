using Iniciacao.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iniciacao.Services
{
    public interface IQuestaoService
    {
        void Insert(Questao questao);
        Questao GetById(long id);
        IEnumerable<Questao> GetAll();
        void Update(Questao questao);
        void Delete(Questao questao);
    }
}
