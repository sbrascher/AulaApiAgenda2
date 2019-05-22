using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendaAPI2.Dominio.Entidades;
using AgendaAPI2.Dominio.Servicos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgendaAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatosController : ControllerBase
    {
        private readonly IContatoServico servico;

        public ContatosController(IContatoServico servico)
        {
            this.servico = servico;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(servico.Obter());
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(servico.Obter(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] Contato contato)
        {
            var erros = servico.Criar(contato);

            if (erros.Count > 0)
            {
                return BadRequest(erros);
            }

            return CreatedAtAction("Get", new { id = contato.Id }, contato);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Contato contato)
        {
            if (id != contato.Id)
                return BadRequest(new List<string> { "Id inválido" });

            var erros = servico.Alterar(contato);

            if (erros.Count > 0)
                return BadRequest(erros);

            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (id == 0)
                return BadRequest(new List<string> { "Id inválido" });

            var contato = servico.Obter(id);

            if (contato == null)
                return NotFound();

            servico.Excluir(contato);

            return Ok();
        }
    }
}
