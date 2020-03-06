using myNotesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myNotesApp.Controllers
{
    public class ScratchPadController : Controller
    {

        private myNotesAppDBEntities _context;

        public ScratchPadController()
        {
            _context = new myNotesAppDBEntities();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: ScratchPad
        public ActionResult Index()
        {

            var scratchNotes = _context.scratchpads.SingleOrDefault(c => c.id == 1);
            
            return View(scratchNotes);
        }

        public ActionResult Save(String content)
        {
            var scratchpadDB = _context.scratchpads.SingleOrDefault(c => c.id == 1);

            scratchpadDB.content = content;
            
            
            
            
            _context.SaveChanges();
          //  _context.scratchpads.Add;
            return RedirectToAction("Index","ScratchPad");
        }
    }
}