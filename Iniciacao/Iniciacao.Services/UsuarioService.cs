using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iniciacao.Domain;
using Iniciacao.Data;

namespace Iniciacao.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IRepository<Usuario> _usuarioRepository;

        public UsuarioService(IRepository<Usuario> usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public void Delete(Usuario usuario)
        {
            _usuarioRepository.Delete(usuario);
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _usuarioRepository.GetAll();
        }

        public Usuario GetById(long id)
        {
            return _usuarioRepository.GetById(id);
        }

        public void Insert(Usuario usuario)
        {
            _usuarioRepository.Insert(usuario);
        }

        public void Update(Usuario usuario)
        {
            _usuarioRepository.Update(usuario);
        }
    }
}
