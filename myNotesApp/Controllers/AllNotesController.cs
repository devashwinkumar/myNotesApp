using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using myNotesApp.Models;

namespace myNotesApp.Controllers
{
    public class AllNotesController : Controller
    {
        private myNotesAppDBEntities _context;

        public AllNotesController()
        {
            _context = new myNotesAppDBEntities();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: AllNotes
        public ActionResult Index()
        {
            return View();
        }
    }
}