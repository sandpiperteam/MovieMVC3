using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieMVC3.Models;

namespace MovieMVC3.Controllers
{
    public class FilmsController : Controller
    {

        private MovieRepository movieRepository = new MovieRepository();

        //
        // GET: /Films/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Films/Details/5

        public ActionResult Details(int id)
        {
            Film film = movieRepository.FindFilmById(id);

            if (film == null)
            {
                return View("Film not found");
            }
            else
            {
                return View("Film", film);
            }
        }

        //
        // GET: /Films/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Films/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Films/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Films/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Films/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Films/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
