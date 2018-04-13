using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMvc.Areas.area.Controllers
{
    public class LoginController : Controller
    {
        // GET: area/Login
        public ActionResult Index()
        {
            return View();
        }
      
        public ActionResult Login()
        {
            ViewBag.name = "qgb";
            ViewBag.pwd = "ssss";
            return View();
        }



        // GET: area/Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: area/Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: area/Login/Create
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

        // GET: area/Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: area/Login/Edit/5
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

        // GET: area/Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: area/Login/Delete/5
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
