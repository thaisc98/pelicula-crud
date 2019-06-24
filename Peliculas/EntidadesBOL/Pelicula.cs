﻿using System;

namespace EntidadesBOL
{
	public class Pelicula
	{
		public int Id { get; set; }

		public string Titulo { get; set; }

		public string Descripcion { get; set; }

		public string ImagenURL { get; set; }

		public DateTime FechaDeEstreno { get; set; }

		public DateTime AgregadoEn { get; set; }
	}
}
