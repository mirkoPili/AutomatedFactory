using AutomatedFactory.Model;
using AutomatedFactory.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomatedFactory.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VerniciaController : Controller
    {
        private readonly IVerniciaferroRepository _repository;

        public VerniciaferroController(IVerniciaferroRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("getall")]
        public async Task<ActionResult<IEnumerable<verniciaferro>>> getAll()
        {
            var listVernicia = await _repository.getAllAsncy();

            return Ok(listVernicia);

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<verniciaferro>> getCodiceProduzione(int id)
        {
            var produzione = await _repository.Selbyid(id);

            return Ok(produzione);
        }

        [HttpPost]
        public ActionResult insert([FromBody] verniciaaferro verniciaFerro)
        {
            var vernicia = _repository.InsArticoli(verniciaFerro);

            return Accepted(vernicia);
        }

        [HttpDelete("{id}")]
        public ActionResult delete(int id)
        {
            var deleteProcesso = _repository.DelProcesso(id);

            return Accepted(deleteProcesso);
        }
        [HttpPut]
        public ActionResult update(verniciaferro verniciaferro)
        {
            var update = _repository.Updverniciaferro(verniciaferro);

            return Accepted(update);
        }

    }

}
