using System.Collections.Generic;

namespace GestorAfastamentos.Domain.Interfaces.Entidades
{
    public interface IAfastamento
    {
        void Cadastrar(Afastamento afastamento);
        void Alterar(Afastamento afastamento);
        void Excluir(Afastamento afastamento);
        List<Afastamento> Listar();
    }
}
