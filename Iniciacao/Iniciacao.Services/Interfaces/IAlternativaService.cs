using Iniciacao.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iniciacao.Services
{
    public interface IAlternativaService
    {
        void Insert(Alternativa alternativa);
        Alternativa GetById(long id);
        IEnumerable<Alternativa> GetAll();
        void Update(Alternativa alternativa);
        void Delete(Alternativa alternativa);
    }
}
