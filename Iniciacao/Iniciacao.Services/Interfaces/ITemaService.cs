using Iniciacao.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iniciacao.Services
{
    public interface IUsuarioService
    {
        void Insert(Usuario usuario);
        Usuario GetById(long id);
        IEnumerable<Usuario> GetAll();
        void Update(Usuario usuario;
        void Delete(Usuario usuario);
    }
}
