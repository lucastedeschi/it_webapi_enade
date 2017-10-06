using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Iniciacao.WebApi.Models
{
    public class TemaModel
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}