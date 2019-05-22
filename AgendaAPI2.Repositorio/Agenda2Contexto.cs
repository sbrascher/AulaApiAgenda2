using AgendaAPI2.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaAPI2.Repositorio
{
    public class Agenda2Contexto : DbContext
    {
        public Agenda2Contexto(DbContextOptions<Agenda2Contexto> options)
            :base(options)
        {

        }

        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
    }
}
