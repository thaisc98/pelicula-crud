using System.Linq;
using System.Threading.Tasks;
using AccesoDAL.IRepos;
using EntidadesBOL;
using Microsoft.AspNetCore.Mvc;
using Peliculas.ViewModels;

namespace Peliculas.Controllers
{
	public class PeliController : Controller
	{
		private readonly IPelisRepo peli;


		public PeliController(IPelisRepo peli) => this.peli = peli;
	
		public async Task<IActionResult> Index()
		{
			var x =  await peli.ObtenerTodas();
			

			var pelisModel = x.Select(y => new PeliIndexViewModel()
			{ 
				//x = y
				Id = y.Id,
				Titulo = y.Titulo,
				Descripcion = y.Descripcion,
				ImagenURL = y.ImagenURL,
				FechaDeEstreno = y.FechaDeEstreno

			});

            return View(pelisModel);
        }

		[HttpGet]
		public IActionResult Agregar() => View();

		[HttpPost]
		public async Task<IActionResult> Agregar(PeliIndexViewModel p)
		{
			if (ModelState.IsValid)
			{
				var pelicula = new Pelicula()
				{
					Titulo = p.Titulo,
					Descripcion = p.Descripcion,
					ImagenURL = p.ImagenURL,
					FechaDeEstreno = p.FechaDeEstreno
				};

				await peli.Agregar(pelicula);
				return RedirectToAction("Index");
			}

			return View(p);

		}

		[HttpGet]
		public async Task<IActionResult> Actualizar(int id)
		{
			var x = await peli.ObtenerPelicula(id);

			var peliModel = new PeliIndexViewModel()
			{
				Id = x.Id,
				Titulo = x.Titulo,
				Descripcion = x.Titulo,
				ImagenURL = x.ImagenURL,
				FechaDeEstreno = x.FechaDeEstreno
			};

			return View(peliModel);
		}

		[HttpPost]
		public async Task<IActionResult> Actualizar(PeliIndexViewModel p)
		{
			if (ModelState.IsValid)
			{
				var peliModel = new Pelicula()
				{
					Id = p.Id,
					Titulo = p.Titulo,
					Descripcion = p.Descripcion,
					ImagenURL = p.ImagenURL,
					FechaDeEstreno = p.FechaDeEstreno

				};

				await peli.Actualizar(peliModel);

				return RedirectToAction("Index");
			}

			return View(p);
		}

		[HttpGet]
		public async Task<IActionResult> Detalles(int id)
		{
			var x = await peli.ObtenerPelicula(id);

			var pModel = new PeliDetalleViewModel()
			{
				Id = x.Id,
				Titulo = x.Titulo,
				Descripcion = x.Descripcion,
				ImagenURL = x.ImagenURL,
				FechaDeEstreno = x.FechaDeEstreno,
				AgregadoEn = x.AgregadoEn
			};

			return View(pModel);
		}

		[HttpGet]
		public async Task<IActionResult> Eliminar(int id)
		{
			 await peli.Eliminar(id);

			 return RedirectToAction("Index");
		}






	}
}