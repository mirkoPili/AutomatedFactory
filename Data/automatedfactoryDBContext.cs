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

		public DbSet<piegaferro> piegaferro { get; set; }

		public DbSet<Verniciaferro> verniciaferro { get; set; }

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

			modelBuilder.Entity<piegaferro>(e =>
			{
				e.ToTable("Piegaferro");
				e.HasKey(e => e.id);
				e.Property(e => e.angoloInclinazione);
				e.Property(e => e.avvitamento);
				
			});
			modelBuilder.Entity<verniciaferro>(e =>
			{
				e.ToTable("Verniciaferro");
				e.HasKey(e => e.id);
				e.Property(e => e.verniciato);
				e.Property(e => e.sabbiato);
				
			});
		}
	}
}
