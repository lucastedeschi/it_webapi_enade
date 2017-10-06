using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iniciacao.Domain;
using Iniciacao.Data;

namespace Iniciacao.Services
{
    public class TemaService : ITemaService
    {
        private readonly IRepository<Tema> _temaRepository;

        public TemaService(IRepository<Tema> temaRepository)
        {
            _temaRepository = temaRepository;
        }

        public void Delete(Tema tema)
        {
            _temaRepository.Delete(tema);
        }

        public IEnumerable<Tema> GetAll()
        {
            return _temaRepository.GetAll();
        }

        public Tema GetById(long id)
        {
            return _temaRepository.GetById(id);
        }

        public void Insert(Tema tema)
        {
            _temaRepository.Insert(tema);
        }

        public void Update(Tema tema)
        {
            _temaRepository.Update(tema);
        }
    }
}
