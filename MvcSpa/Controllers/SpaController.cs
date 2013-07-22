using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace MvcSpa.Controllers
{
    public class SpaController : Controller
    {
        //
        // GET: /Spa/

        public ActionResult Index()
        {
            ViewData["Title"] = "SPA Title";
            ViewData["Message"] = "SPA work";

            return View("Home");
        }

        public ViewResult List()
        {
            var processList = from p in Process.GetProcesses() where p.ProcessName.StartsWith("s")  select p;

            ViewData.Model = processList.ToList();

            return View();
        }

        //
        // GET: /Spa/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Spa/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Spa/Create

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
        // GET: /Spa/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Spa/Edit/5

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
        // GET: /Spa/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Spa/Delete/5

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
