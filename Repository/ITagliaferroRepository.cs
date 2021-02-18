﻿using AutomatedFactory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomatedFactory.Repository
{
	public interface ITagliaferroRepository
	{
		public Task<tagliaferro> Selbyid(int id);
		public Task<IEnumerable<tagliaferro>> getAllAsncy();
		bool InsArticoli(tagliaferro tagliaFerro);
		bool UpdArticoli(tagliaferro tagliaFerro);
		bool DelArticoli(tagliaferro tagliaFerro);
		bool Salva();
	}
}
