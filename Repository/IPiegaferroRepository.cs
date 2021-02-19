using AutomatedFactory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomatedFactory.Repository
{
	public interface IPiegaferroRepository
	{
		public Task<piegaferro> Selbyid(int id);
		public Task<IEnumerable<piegaferro>> getAllAsncy();
		bool InsArticoli(piegaferro piegaFerro);
		bool Updpiegaferro(piegaferro piegaFerro);
		bool DelProcesso(int id);
		bool Salva();
	}
}