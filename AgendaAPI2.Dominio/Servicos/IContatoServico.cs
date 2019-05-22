using AgendaAPI2.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaAPI2.Dominio.Servicos
{
    public interface IContatoServico
    {
        List<string> Criar(Contato contato);
        List<string> Alterar(Contato contato);
        void Excluir(Contato contato);
        Contato Obter(int id);
        List<Contato> Obter();
    }
}
