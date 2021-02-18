using AutomatedFactory.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomatedFactory.Data
{
    public class automatedfactoryDBContext : DbContext
    {

		public automatedfactoryDBContext(DbContextOptions <automatedfactoryDBContext> options) : base(options)
		{
		}

		public DbSet<tagliaferro> tagliaferro { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<tagliaferro>(e =>
			{
				e.ToTable("Tagliaferro");
				e.HasKey(e => e.id);
				e.Property(e => e.Misuraferro);
				e.Property(e => e.TipoMetallo);
				e.Property(e => e.Filettatura);
			});
		}
	}
}
