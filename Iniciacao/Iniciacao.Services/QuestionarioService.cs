using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iniciacao.Domain;
using Iniciacao.Data;

namespace Iniciacao.Services
{
    public class QuestionarioService : IQuestionarioService
    {
        private readonly IRepository<Questionario> _questionarioRepository;

        public QuestionarioService(IRepository<Questionario> questionarioRepository)
        {
            _questionarioRepository = questionarioRepository;
        }

        public void Delete(Questionario questionario)
        {
            _questionarioRepository.Delete(questionario);
        }

        public IEnumerable<Questionario> GetAll()
        {
            return _questionarioRepository.GetAll();
        }

        public Questionario GetById(long id)
        {
            return _questionarioRepository.GetById(id);
        }

        public void Insert(Questionario questionario)
        {
            _questionarioRepository.Insert(questionario);
        }

        public void Update(Questionario questionario)
        {
            _questionarioRepository.Update(questionario);
        }
    }
}
