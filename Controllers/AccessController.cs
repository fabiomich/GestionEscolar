using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GestionEscolar.Models;

namespace GestionEscolar.Controllers
{
    public class AccessController : Controller
    {
        // GET: Access
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Enter(string user, string password)
        {
            try
            {
                using (var db = new EscuelaEntities())
                {
                    var lista = from d in db.Usuarios
                                where d.email == user && d.password == password && d.id_estado == 1
                                select d;

                    if (lista.Count() > 0)
                    {
                        Usuarios usuario = lista.First();

                        Session["User"] = usuario;

                        return Content("1");
                    }
                    else
                    {
                        return Content("Usuario invalido");
                    }
                }
            }
            catch (Exception ex)
            {
                return Content("Ocurrio un error :( " + ex.Message);
            }
        }

        public ActionResult Logout()
        {
            Session["User"] = null;
            return Redirect("~/Access/Index");
        }

        // GET: Access/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Access/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Access/Create
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

        // GET: Access/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Access/Edit/5
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

        // GET: Access/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Access/Delete/5
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
