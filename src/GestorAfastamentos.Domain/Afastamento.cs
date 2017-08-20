using System;

namespace GestorAfastamentos.Domain
{
    public class Afastamento
    {
        public int AfastamentoId { get; set; }
        public string Descricao { get; set; }
        public int TipoAfastamento { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public bool DecorrenciaNoTrabalho { get; set; }        
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public int FuncionarioId { get; set; }
        public virtual Funcionario Funcionario { get; set; }
    }
}
