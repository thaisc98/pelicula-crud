using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EntidadesBOL;

namespace AccesoDAL.IRepos
{
	public interface IPelisRepo
	{
		Task<Pelicula> ObtenerPelicula(int id);

		Task<IEnumerable<Pelicula>> ObtenerTodas();

		Task Agregar(Pelicula peli);
		Task Actualizar(Pelicula peli);
		Task Eliminar(int id);

	}

}
