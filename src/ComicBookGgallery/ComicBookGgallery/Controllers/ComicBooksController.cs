using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookGgallery.Models;

namespace ComicBookGgallery.Controllers
{
    public class ComicBooksController : Controller
    {
		private ComicBookRepository _comicBookRepository = null;

		// Initializer
		public ComicBooksController()
		{
			_comicBookRepository = new ComicBookRepository();
		}

		public ActionResult Index()
		{
			var comicBooks = _comicBookRepository.GetComicBooks();
			return View(comicBooks);
		}

		public ActionResult Detail(int? id)
		{
			if (id == null)
			{
				return HttpNotFound();
			}

			var comicBook = _comicBookRepository.GetComicBook(id.Value);


			return View(comicBook);
		}
    }
}
