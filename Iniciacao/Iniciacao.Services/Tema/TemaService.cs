using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iniciacao.Data;
using Iniciacao.Domain;

namespace Iniciacao.Services.Tema
{
    public class TemaService : ITemaService
    {
        private readonly IRepository<Domain.Tema> _repository;

        public TemaService(IRepository<Domain.Tema> repository)
        {
            _repository = repository;
        }

        public List<Domain.Tema> GetAll()
        {
            return _repository.GetAll().ToList();
        }

        public Domain.Tema GetTemaById(int id)
        {
            return _repository.GetById(id);
        }

        public void InsertTema(Domain.Tema tema)
        {
            _repository.Insert(tema);
        }
    }
}
