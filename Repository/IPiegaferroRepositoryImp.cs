using AutomatedFactory.Data;
using AutomatedFactory.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomatedFactory.Repository
{
	public class PiegaFerroRepositoryImp : IPiegaferroRepository
	{
		private readonly automatedfactoryDBContext _db;

		public PiegaFerroRepositoryImp(automatedfactoryDBContext db)
		{
			_db = db;
		}

		public bool DelProcesso(int id)
		{
			var trovaId = _db.piegaferro.Find(id);
			_db.piegaferro.Remove(trovaId);
			return Salva();
		}

		public async Task<IEnumerable<piegaferro>> getAllAsncy()
		{
			return await _db.piegaferro.ToListAsync();
		}

		public bool InsArticoli(piegaferro piegaFerro)
		{
			_db.Add(piegaFerro);
			return Salva();
		}

		public bool Salva()
		{
			var saved = _db.SaveChanges();
			return saved >= 0 ? true : false;
		}



		public async Task<piegaferro> Selbyid(int id)
		{
			return await _db.piegaferro.FindAsync(id);
		}


		public bool Updpiegaferro(piegaferro piegaFerro)
		{
			_db.piegaferro.Update(piegaFerro);
			return Salva();
		}

		
		
	}
}