using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Iniciacao.WebApi.Models
{
    public class QuestaoModel
    {
        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Resposta { get; set; }
        public int EnadeAno { get; set; }
        public int TemaId { get; set; }
    }
}