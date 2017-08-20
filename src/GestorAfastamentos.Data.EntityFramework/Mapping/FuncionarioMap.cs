using GestorAfastamentos.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorAfastamentos.Data.EntityFramework.Mapping
{
    public class FuncionarioMap : EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioMap()
        {
            //Famoso fluent API do entity framework

            //HasKey(k => k.FuncionarioId); //Configured in Contexto

            Property(p => p.Nome).HasMaxLength(50);
            Property(p => p.Telefone).HasMaxLength(15);

            ToTable("Funcionario");
        }
    }
}
