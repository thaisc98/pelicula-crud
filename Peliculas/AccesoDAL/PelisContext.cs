using EntidadesBOL;
using Microsoft.EntityFrameworkCore;

namespace AccesoDAL
{		
	public class PelisContext : DbContext // Mi representacion de BD es PelisContext  en EF:D
	{
		public PelisContext(DbContextOptions options) : base(options)
		{

		}

		//DbSet son las tablas
		public DbSet<Pelicula> Peliculas { get; set; }
	}
}
