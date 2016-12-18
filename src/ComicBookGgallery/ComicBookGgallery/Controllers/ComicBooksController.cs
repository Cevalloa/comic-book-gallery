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
		public ActionResult Detail()
		{

			var comicBook = new ComicBook()
			{
				SeriesTitle = "The amazing spider man",
				IssueNumber = 700,
				DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
				Artists = new Artist[]
				{
					new Artist() { Name ="Victor", Role ="main artist"},
					new Artist() { Name ="Sully", Role ="main character"},
				}
			};


			return View(comicBook);
		}
    }
}
