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
        public async Task<ActionResult<IEnumerable<Verniciaferro>>> getAll()
        {
            var listVernicia = await _repository.getAllAsncy();

            return Ok(listVernicia);

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Verniciaferro>> getCodiceProduzione(int id)
        {
            var produzione = await _repository.Selbyid(id);

            return Ok(produzione);
        }

        [HttpPost]
        public ActionResult insert([FromBody] Verniciaferro verniciaFerro)
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
        

    }

}
