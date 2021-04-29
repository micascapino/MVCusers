using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COAChallenge.NETFramework.Models;

namespace COAChallenge.NETFramework.Controllers
{
    public class HomeController : Controller
    {
        private UsuarioContext context = new UsuarioContext();

        public ActionResult Index()
        {
            List<Usuario> lista = context.Usuarios.ToList();
            return View(lista);
        }

        public ActionResult Create()
        {
            Usuario nuevoUsuario = new Usuario();
            return View("Create", nuevoUsuario);
        }

        [HttpPost]
        public ActionResult Create(Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", usuario);
            }
            else
            {
            context.Usuarios.Add(usuario);
            context.SaveChanges();
            return RedirectToAction("Index");
            }
            
        }

        //GET Delete
        public ActionResult Delete(int id)
        {
            Usuario usuario = context.Usuarios.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View("Delete", usuario);
        }

        //POST Delete
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Usuario usuario = context.Usuarios.Find(id);
            context.Usuarios.Remove(usuario);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        //GET Edit
        public ActionResult Edit(int id)
        {
            Usuario usuario = context.Usuarios.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View("Edit", usuario);
        }

        //POST Delete
        [HttpPost]
        [ActionName("Edit")]
        public ActionResult EditConfirmed(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                context.Entry(usuario).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usuario);
           
        }

    }
}