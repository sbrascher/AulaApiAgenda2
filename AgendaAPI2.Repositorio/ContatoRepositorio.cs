using AgendaAPI2.Dominio.Entidades;
using AgendaAPI2.Dominio.Repositorios;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgendaAPI2.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly Agenda2Contexto contexto;

        public ContatoRepositorio(Agenda2Contexto contexto)
        {
            this.contexto = contexto;
        }

        public void Alterar(Contato contato)
        {
            contexto.Entry<Contato>(contato).State = EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Criar(Contato contato)
        {
            contexto.Contatos.Add(contato);
            contexto.SaveChanges();
        }

        public void Excluir(Contato contato)
        {
            contexto.Contatos.Remove(contato);
            contexto.SaveChanges();
        }

        public Contato Obter(int id)
        {
            return contexto
                .Contatos
                .Where(x => x.Id == id)
                .SingleOrDefault();
        }

        public List<Contato> Obter()
        {
            return contexto.Contatos.ToList();
        }
    }
}
