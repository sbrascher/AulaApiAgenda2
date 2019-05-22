using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaAPI2.Dominio.Entidades
{
    public class Contato
    {
        public Contato()
        {
            Telefones = new List<Telefone>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Telefone> Telefones { get; set; }
    }
}
