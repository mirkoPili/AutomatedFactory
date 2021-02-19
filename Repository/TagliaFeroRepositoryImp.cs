using AutomatedFactory.Data;
using AutomatedFactory.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomatedFactory.Repository
{
	public class TagliaFeroRepositoryImp : ITagliaferroRepository
	{
		private readonly automatedfactoryDBContext _db;

		public TagliaFeroRepositoryImp(automatedfactoryDBContext db)
		{
			_db = db;
		}

		public bool DelProcesso(int id)
		{
			var trovaId = _db.tagliaferro.Find(id);
			_db.tagliaferro.Remove(trovaId);
			return Salva();
		}

		public async Task<IEnumerable<tagliaferro>> getAllAsncy()
		{
			return await _db.tagliaferro.ToListAsync();
		}

		public bool InsArticoli(tagliaferro tagliaFerro)
		{
			_db.Add(tagliaFerro);
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

