using Iniciacao.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iniciacao.Services
{
    public interface ITemaService
    {
        void Insert(Tema tema);
        Tema GetById(long id);
        IEnumerable<Tema> GetAll();
        void Update(Tema tema);
        void Delete(Tema tema);
    }
}
