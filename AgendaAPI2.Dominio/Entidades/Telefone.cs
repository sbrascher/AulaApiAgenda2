using AgendaAPI2.Dominio.Entidades.Enums;

namespace AgendaAPI2.Dominio.Entidades
{
    public class Telefone
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public ETipoTelefone Tipo { get; set; }

        public Contato Contato { get; set; }
        public int ContatoId { get; set; }
    }
}
