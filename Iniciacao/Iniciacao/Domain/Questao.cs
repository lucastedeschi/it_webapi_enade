using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iniciacao.Domain
{
    public class Questao
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Resposta { get; set; }
        public int EnadeAno { get; set; }
        public int TemaId { get; set; }
        public virtual Tema Tema { get; set; }
    }
}
