using AgendaAPI2.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaAPI2.Dominio.Repositorios
{
    public interface IContatoRepositorio
    {
        void Criar(Contato contato);
        void Alterar(Contato contato);
        void Excluir(Contato contato);
        Contato Obter(int id);
        List<Contato> Obter();
    }
}
