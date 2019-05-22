using AgendaAPI2.Dominio.Entidades;
using AgendaAPI2.Dominio.Repositorios;
using AgendaAPI2.Dominio.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaAPI2.Servico
{
    public class ContatoServico : IContatoServico
    {
        private readonly IContatoRepositorio repositorio;

        public ContatoServico(IContatoRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public List<string> Alterar(Contato contato)
        {
            var erros = new List<string>();

            if (String.IsNullOrEmpty(contato.Nome))
            {
                erros.Add("Nome não informado");
            }

            if (erros.Count == 0)
            {
                repositorio.Alterar(contato);
            }


            return erros;
        }

        public List<string> Criar(Contato contato)
        {
            var erros = new List<string>();

            if (String.IsNullOrEmpty(contato.Nome))
            {
                erros.Add("Nome não informado");
            }

            if (erros.Count == 0)
            {
                repositorio.Criar(contato);
            }


            return erros;
        }

        public void Excluir(Contato contato)
        {
            repositorio.Excluir(contato);
        }

        public Contato Obter(int id)
        {
            return repositorio.Obter(id);
        }

        public List<Contato> Obter()
        {
            return repositorio.Obter();
        }
    }
}
