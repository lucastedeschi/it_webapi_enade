using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iniciacao.Domain
{
    public class Tema
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public ICollection<Questao> Questoes { get; set; }
    }
}
