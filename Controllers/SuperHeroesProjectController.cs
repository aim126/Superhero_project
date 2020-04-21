using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperheroesProject.Data;
namespace SuperheroesProject.Controllers
{ 

       
 
        public class SuperHeroesProjectController : Controller
 {
        private readonly ApplicationDbContext _context;
        public SuperHeroesProjectController(ApplicationDbContext context)
        { 
            _context = context;
        }
       
        
        // GET: SuperHeroesProject
        public ActionResult Index()
        {
            return View();
        }

        // GET: SuperHeroesProject/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SuperHeroesProject/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuperHeroesProject/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHeroesProject/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SuperHeroesProject/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHeroesProject/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SuperHeroesProject/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}