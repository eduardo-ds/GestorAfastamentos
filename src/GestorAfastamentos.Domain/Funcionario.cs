using System;
using System.Collections.Generic;

namespace GestorAfastamentos.Domain
{
    public class Funcionario
    {
        public int FuncionarioId { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public virtual IEnumerable<Afastamento> Afastamentos { get; set; }
    }
}
