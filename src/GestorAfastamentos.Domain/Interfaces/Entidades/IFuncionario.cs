using System.Collections.Generic;

namespace GestorAfastamentos.Domain.Interfaces.Entidades
{
    public interface IFuncionario
    {
        void Cadastrar(Funcionario funcionario);
        void Alterar(Funcionario funcionario);
        void Excluir(Funcionario funcionario);
        List<Funcionario> Listar();
    }
}
