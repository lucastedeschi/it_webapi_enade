using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iniciacao.Services.Tema
{
    public interface ITemaService
    {
        List<Domain.Tema> GetAll();
        void InsertTema(Domain.Tema tema);
        Domain.Tema GetTemaById(int id);
    }
}
