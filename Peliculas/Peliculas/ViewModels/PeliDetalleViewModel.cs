using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Peliculas.ViewModels
{
	public class PeliDetalleViewModel
	{
		public int Id { get; set; }

		public string Titulo { get; set; }

		public string Descripcion { get; set; }

		public string ImagenURL { get; set; }

		public DateTime FechaDeEstreno { get; set; }

		public DateTime AgregadoEn { get; set; }
	}
}
