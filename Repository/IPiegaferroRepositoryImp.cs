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

		public PiegaferroRepositoryImp(automatedfactoryDBContext db)
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



		public async Task<tagliaferro> Selbyid(int id)
		{
			return await _db.tagliaferro.FindAsync(id);
		}

		public bool Updtagliaferro(tagliaferro tagliaFerro)
		{
			_db.tagliaferro.Update(tagliaFerro);
			return Salva();
		}

	}
}