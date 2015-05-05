using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using $safeprojectname$.Models;

namespace $safeprojectname$.Controllers
{
    public class MoviesController : Controller
    {
        //
        // GET: /Movies/
        MoviesEntities1 me = new MoviesEntities1();

        public ActionResult Index()
        {
            return View(me.MovieDBs.ToList());
        }

        //
        // GET: /Movies/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Movies/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Movies/Create

        [HttpPost]
        public ActionResult Create(MovieDB mv)
        {
            try
            {

                me.AddToMovieDBs(mv);
                me.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Movies/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Movies/Edit/5

        [HttpPost]
        public ActionResult Edit(MovieDB mv)
        {
            try
            {
                int id = mv.ID;
                MovieDB mvu = (from mv1 in me.MovieDBs where mv1.ID == id select mv1).First();

                mvu.Title = mv.Title;
                mvu.Director = mv.Director;
                mvu.Date = mv.Date;

                me.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Movies/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Movies/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, MovieDB mv)
        {
            try
            {

                MovieDB mvd = (from mv1 in me.MovieDBs where mv1.ID == id select mv1).First();

                me.DeleteObject(mvd);

                me.SaveChanges();
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
