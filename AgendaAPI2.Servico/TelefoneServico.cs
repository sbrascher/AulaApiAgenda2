using AgendaAPI2.Dominio.Entidades;
using AgendaAPI2.Dominio.Repositorios;
using AgendaAPI2.Dominio.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaAPI2.Servico
{
    public class TelefoneServico : ITelefoneServico
    {
        private readonly ITelefoneRepositorio repositorio;

        public TelefoneServico(ITelefoneRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public List<string> Alterar(Telefone telefone)
        {
            var erros = new List<string>();

            if (String.IsNullOrEmpty(telefone.Numero))
            {
                erros.Add("Número não informado");
            }

            if (erros.Count == 0)
            {
                repositorio.Alterar(telefone);
            }


            return erros;
        }

        public List<string> Criar(Telefone telefone)
        {
            var erros = new List<string>();

            if (String.IsNullOrEmpty(telefone.Numero))
            {
                erros.Add("Número não informado");
            }

            if (erros.Count == 0)
            {
                repositorio.Criar(telefone);
            }


            return erros;
        }

        public void Excluir(Telefone telefone)
        {
            repositorio.Excluir(telefone);
        }

        public List<Telefone> ObterPorContato(int contatoId)
        {
            return repositorio.ObterPorContato(contatoId);
        }

        public Telefone Obter(int id)
        {
            return repositorio.Obter(id);
        }
    }
}
