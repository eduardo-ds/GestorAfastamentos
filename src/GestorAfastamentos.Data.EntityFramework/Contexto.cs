using GestorAfastamentos.Data.EntityFramework.Mapping;
using GestorAfastamentos.Domain;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace GestorAfastamentos.Data.EntityFramework
{
    public class Contexto : DbContext
    {
        public Contexto() : base("GestorAfastamento") { }

        DbSet<Funcionario> Funcionarios { get; set; }
        DbSet<Afastamento> Afastamentos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //FuncionarioId ou AfastamentoId
            modelBuilder.Properties()
                .Where(w => w.Name == w.ReflectedType.Name + "Id")
                .Configure(c => c.IsKey());

            //transformar nvarchar => varchar
            modelBuilder.Properties<string>()
                .Configure(c => c.HasColumnType("varchar"));

            //configuração padrao para atribuir 100 de tamanho maximo para strings
            modelBuilder.Properties<string>()
                .Configure(c => c.HasMaxLength(100));


            modelBuilder.Configurations.Add(new FuncionarioMap());
            modelBuilder.Configurations.Add(new AfastamentoMap());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(w=> w.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }

            return base.SaveChanges();
        }
    }
}
