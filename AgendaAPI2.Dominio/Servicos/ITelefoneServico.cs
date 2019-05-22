using AgendaAPI2.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaAPI2.Dominio.Servicos
{
    public interface ITelefoneServico
    {
        List<string> Criar(Telefone telefone);
        List<string> Alterar(Telefone telefone);
        void Excluir(Telefone telefone);
        Telefone Obter(int id);
        List<Telefone> ObterPorContato(int contatoId);
    }
}
