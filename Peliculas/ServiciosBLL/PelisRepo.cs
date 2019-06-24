using AccesoDAL;
using AccesoDAL.IRepos;
using EntidadesBOL;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiciosBLL
{
	public class PelisRepo : BaseContext, IPelisRepo
	{
		public async Task<Pelicula> ObtenerPelicula(int id) =>
				await db.Peliculas.FindAsync(id);

		public async Task<IEnumerable<Pelicula>> ObtenerTodas() =>
			await db.Peliculas.ToListAsync();


		public async Task Agregar(Pelicula peli)
		{
			await db.Peliculas.AddAsync(peli);
			await db.SaveChangesAsync();
		}

		public async Task Actualizar(Pelicula peli)
		{
			db.Peliculas.Update(peli);
			await db.SaveChangesAsync();
		}


		public async Task Eliminar(int id)
		{
			var peli = await ObtenerPelicula(id);
			db.Peliculas.Remove(peli);
			await db.SaveChangesAsync();
		}

		public PelisRepo(PelisContext db) : base(db)
		{
		}
	}
}
