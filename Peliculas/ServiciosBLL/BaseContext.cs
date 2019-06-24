using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using AccesoDAL;
using Microsoft.EntityFrameworkCore;

namespace ServiciosBLL
{
	public class BaseContext
	{
		protected PelisContext db;

		public BaseContext(PelisContext db) => this.db = db;
	}
}
