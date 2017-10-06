using Iniciacao.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iniciacao.Data.Mapping 
{
    public class QuestaoMap : EntityTypeConfiguration<Questao>
    {
        public QuestaoMap()
        {
            HasKey(q => q.Id);
            Property(q => q.Descricao).IsRequired().HasMaxLength(10000);

            Property(q => q.TemaId).IsRequired();
            HasRequired(q => q.Tema).WithMany().HasForeignKey(q => q.TemaId);
        }
    }
}
