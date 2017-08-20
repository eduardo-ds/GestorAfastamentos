using System.Collections.Generic;

namespace GestorAfastamentos.Domain.Interfaces.Repositorios
{
    public interface IAfastamentoRepositorio
    {
        void Cadastrar(Afastamento afastamento);
        void Alterar(Afastamento afastamento);
        void Excluir(Afastamento afastamento);
        List<Afastamento> Listar();
    }
}
