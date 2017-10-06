using Iniciacao.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iniciacao.Services
{
    public interface IQuestionarioService
    {
        void Insert(Questionario questionario);
        Questionario GetById(long id);
        IEnumerable<Questionario> GetAll();
        void Update(Questionario questionario);
        void Delete(Questionario questionario);
    }
}
