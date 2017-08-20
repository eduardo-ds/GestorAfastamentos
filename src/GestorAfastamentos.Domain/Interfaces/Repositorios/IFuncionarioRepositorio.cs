using System.Collections.Generic;

namespace GestorAfastamentos.Domain.Interfaces.Repositorios
{
    public interface IFuncionarioRepositorio
    {
        void Cadastrar(Funcionario funcionario);
        void Alterar(Funcionario funcionario);
        void Excluir(Funcionario funcionario);
        List<Funcionario> Listar();
    }
}
