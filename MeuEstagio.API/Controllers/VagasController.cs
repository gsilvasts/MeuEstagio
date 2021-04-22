using MeuEstagio.API.Infra.Repositories;
using MeuEstagio.API.Interface;
using MeuEstagio.API.Models;
using MeuEstagio.API.ViewModels.Input;
using MeuEstagio.API.ViewModels.Output;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MeuEstagio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VagasController : ControllerBase
    {
        private readonly IVaga _vaga;
        private readonly ICidade _cidade;

        public VagasController(IVaga vaga, ICidade cidade)
        {
            _vaga = vaga;
            _cidade = cidade;
        }

        // GET: api/<VagasController>
        [HttpGet]
        public async Task<List<Vaga>> Get()
        {
            return await _vaga.List();
        }

        // GET api/<VagasController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var vaga = await _vaga.GetById(id);

            return Ok(vaga);
        }

        // POST api/<VagasController>
        [HttpPost]
        public IActionResult Post([FromBody] AddVagaInputModel entidade)
        {
            //var cidade = _cidade.GetEntityById(entidade.IdCidade);


            var vaga = new Vaga(
                entidade.Titulo,
                entidade.Descricao,
                entidade.Funcao,
                entidade.Salario,
                entidade.Requisitos,
                entidade.Desejaveis,
                entidade.IdCidade
                );
            _vaga.Add(vaga);
            return Ok();
            //return CreatedAtAction(
            //    nameof(GetById),
            //    new { id = vaga.Id },
            //    entidade);
        }

        // PUT api/<VagasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VagasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _vaga.Delete(id);
        }
    }
}
