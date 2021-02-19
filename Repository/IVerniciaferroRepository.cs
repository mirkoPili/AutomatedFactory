using AutomatedFactory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomatedFactory.Repository
{
    public interface IVerniciaferroRepository
    {
        public Task<verniciaferro> Selbyid(int id);
        public Task<IEnumerable<verniciaferro>> getAllAsncy();
        bool InsArticoli(verniciaferro verniciaFerro);
        bool Updpiegaferro(verniciaferro verniciaFerro);
        bool DelProcesso(int id);
        bool Salva();
    }
}
