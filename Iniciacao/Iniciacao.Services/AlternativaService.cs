using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iniciacao.Domain;
using Iniciacao.Data;

namespace Iniciacao.Services
{
    public class AlternativaService : IAlternativaService
    {
        private readonly IRepository<Alternativa> _alternativaRepository;

        public AlternativaService(IRepository<Alternativa> alternativaRepository)
        {
            _alternativaRepository = alternativaRepository;
        }

        public void Delete(Alternativa alternativa)
        {
            _alternativaRepository.Delete(alternativa);
        }

        public IEnumerable<Alternativa> GetAll()
        {
            return _alternativaRepository.GetAll();
        }

        public Alternativa GetById(long id)
        {
            return _alternativaRepository.GetById(id);
        }

        public void Insert(Alternativa alternativa)
        {
            _alternativaRepository.Insert(alternativa);
        }

        public void Update(Alternativa alternativa)
        {
            _alternativaRepository.Update(alternativa);
        }
    }
}
