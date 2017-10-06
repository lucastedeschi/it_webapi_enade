using Iniciacao.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iniciacao.Data.Mapping
{
    public class TemaMap : EntityTypeConfiguration<Tema>
    {
        public TemaMap()
        {
            HasKey(t => t.Id);
            Property(t => t.Descricao).IsRequired().HasMaxLength(20000);
            Property(t => t.Nome).IsRequired().HasMaxLength(500);
        }
    }
}
