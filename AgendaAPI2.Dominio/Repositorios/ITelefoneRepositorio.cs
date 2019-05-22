using AgendaAPI2.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaAPI2.Dominio.Repositorios
{
    public interface ITelefoneRepositorio
    {
        void Criar(Telefone telefone);
        void Alterar(Telefone telefone);
        void Excluir(Telefone telefone);
        Telefone Obter(int id);
        List<Telefone> ObterPorContato(int contatoId);
    }
}
