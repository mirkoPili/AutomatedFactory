using AutomatedFactory.Data;
using AutomatedFactory.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomatedFactory.Repository
{
    public class VerniciaFerroRepositoryImp : IVerniciaferroRepository
    {
        private readonly automatedfactoryDBContext _db;

        public VerniciaFerroRepositoryImp(automatedfactoryDBContext db)
        {
            _db = db;
        }

        public bool DelProcesso(int id)
        {
            var trovaId = _db.verniciaferro.Find(id);
            _db.verniciaferro.Remove(trovaId);
            return Salva();
        }

        public async Task<IEnumerable<Verniciaferro>> getAllAsncy()
        {
            return await _db.verniciaferro.ToListAsync();
        }

        public bool InsArticoli(Verniciaferro verniciaFerro)
        {
            _db.Add(verniciaFerro);
            return Salva();
        }

        public bool Salva()
        {
            var saved = _db.SaveChanges();
            return saved >= 0 ? true : false;
        }



        public async Task<Verniciaferro> Selbyid(int id)
        {
            return await _db.verniciaferro.FindAsync(id);
        }


        public bool Updpiegaferro(Verniciaferro verniciaFerro)
        {
            _db.verniciaferro.Update(verniciaFerro);
            return Salva();
        }



    }
}
