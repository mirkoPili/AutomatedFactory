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
	public class TagliaferoController : Controller
	{
		private readonly ITagliaferroRepository _repository;

		public TagliaferoController(ITagliaferroRepository repository)
		{
			_repository = repository;
		}

		[HttpGet("getall")]
		public async Task<ActionResult<IEnumerable<tagliaferro>>> getAll()
		{
			var listTaglio = await _repository.getAllAsncy();

			return Ok(listTaglio);

		}
		[HttpGet("{id}")]
		public async Task<ActionResult<tagliaferro>> getCodiceProduzione(int  id)
		{
			var produzione = await _repository.Selbyid(id);

			return Ok(produzione);
		}

		[HttpPost]
		public ActionResult insert([FromBody] tagliaferro tagliaFerro)
		{
			var taglia = _repository.InsArticoli(tagliaFerro);

			return Accepted(taglia);
		}

		[HttpDelete("{id}")]
		public ActionResult delete(int id)
		{
			var deleteProcesso = _repository.DelProcesso(id);

			return Accepted(deleteProcesso);
		}

	}

}

