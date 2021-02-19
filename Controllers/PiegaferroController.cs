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
	public class PiegaferroController : Controller
	{
		private readonly IPiegaferroRepository _repository;

		public PiegaferroController(IPiegaferroRepository repository)
		{
			_repository = repository;
		}

		[HttpGet("getall")]
		public async Task<ActionResult<IEnumerable<piegaferro>>> getAll()
		{
			var listPiega = await _repository.getAllAsncy();

			return Ok(listPiega);

		}
		[HttpGet("{id}")]
		public async Task<ActionResult<piegaferro>> getCodiceProduzione(int  id)
		{
			var produzione = await _repository.Selbyid(id);

			return Ok(produzione);
		}

		[HttpPost]
		public ActionResult insert([FromBody] piegaferro piegaFerro)
		{
			var piega = _repository.InsArticoli(piegaFerro);

			return Accepted(piega);
		}

		[HttpDelete("{id}")]
		public ActionResult delete(int id)
		{
			var deleteProcesso = _repository.DelProcesso(id);

			return Accepted(deleteProcesso);
		}
		[HttpPut]
		public ActionResult update(piegaferro piegaferro)
		{
			var update = _repository.Updpiegaferro(piegaferro);

			return Accepted(update);
		}

	}

}
