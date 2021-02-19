using AutomatedFactory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomatedFactory.Repository
{
    public interface IVerniciaferroRepository
    {
        public Task<Verniciaferro> Selbyid(int id);
        public Task<IEnumerable<Verniciaferro>> getAllAsncy();
        bool InsArticoli(Verniciaferro verniciaFerro);
        bool Updpiegaferro(Verniciaferro verniciaFerro);
        bool DelProcesso(int id);
        bool Salva();
    }
}
