using AgendaAPI2.Dominio.Entidades;
using AgendaAPI2.Dominio.Repositorios;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgendaAPI2.Repositorio
{
    public class TelefoneRepositorio : ITelefoneRepositorio
    {
        private readonly Agenda2Contexto contexto;

        public TelefoneRepositorio(Agenda2Contexto contexto)
        {
            this.contexto = contexto;
        }

        public void Alterar(Telefone telefone)
        {
            contexto.Entry<Telefone>(telefone).State = EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Criar(Telefone telefone)
        {
            contexto.Telefones.Add(telefone);
            contexto.SaveChanges();
        }

        public void Excluir(Telefone telefone)
        {
            contexto.Telefones.Remove(telefone);
            contexto.SaveChanges();
        }

        public Telefone Obter(int id)
        {
            return contexto
                .Telefones
                .Where(x => x.Id == id)
                .SingleOrDefault();
        }

        public List<Telefone> ObterPorContato(int contatoId)
        {
            return contexto.Telefones.Where(x => x.ContatoId == contatoId).ToList();
        }
    }
}
