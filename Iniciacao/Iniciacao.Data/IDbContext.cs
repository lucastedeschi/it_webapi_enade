using Iniciacao.Data.Mapping;
using Iniciacao.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iniciacao.Data
{
    public class IDbContext : DbContext
    {
        public IDbContext (): base("IniciacaoDb")
        {

        }

        public DbSet<Questao> Questoes { get; set; }
        public DbSet<Tema> Temas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new QuestaoMap());
            modelBuilder.Configurations.Add(new TemaMap());
        }
    }
}
