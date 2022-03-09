using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracticaMVCCore.UIWeb.Models;

namespace PracticaMVCCore.UIWeb.Controllers
{
    public class ClienteController : Controller
    {
        // GET: ClienteController
        public ActionResult Index()
        {
            List<Cliente> lista = new List<Cliente>();
            lista.Add(new Cliente
            {
                Nombre = "Marvin",
                Apellido = "Barrera",
                Dirrecion = "Sonsonate",
                FechaNacimiento = new DateTime(1988, 09, 13)
            });
            lista.Add(new Cliente
            {
                Nombre = "Juan",
                Apellido = "Barrera",
                Dirrecion = "Izalco",
                FechaNacimiento = new DateTime(1980, 09, 13)
            });
            lista.Add(new Cliente
            {
                Nombre = "Marcos",
                Apellido = "Lopez",
                Dirrecion = "Acajutla",
                FechaNacimiento = new DateTime(2000, 01, 25)
            });
            return View(lista);
        }

        // GET: ClienteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
