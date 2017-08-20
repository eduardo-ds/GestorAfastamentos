using GestorAfastamentos.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorAfastamentos.Data.EntityFramework.Mapping
{
    public class AfastamentoMap : EntityTypeConfiguration<Afastamento>
    {
        public AfastamentoMap()
        {
            // HasKey(k => k.AfastamentoId); //Configured in Contexto

            /* mais configuracoes... */

            /* mais configuracoes... */


            HasRequired(h => h.Funcionario)
            .WithMany()
            .HasForeignKey(fk => fk.FuncionarioId);

            ToTable("Afastamento");
        }
    }
}
