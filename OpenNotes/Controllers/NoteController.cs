using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OpenNotes.Models;

namespace OpenNotes.Controllers
{
    public class NoteController : Controller
    {
        private static IList<NoteModel> notes = new List<NoteModel>()
        {
            new NoteModel(){NoteId = 1, Title = "Pierwsza", Content = "Pierwsza notatka"}
        };
        // GET: Note
        public ActionResult Index()
        {
            return View(notes);
        }

        // GET: Note/Details/5
        public ActionResult Details(int id)
        {
            return View(notes.FirstOrDefault(x => x.NoteId == id));
        }

        // GET: Note/Create
        public ActionResult Create()
        {
            return View(new NoteModel());
        }

        // POST: Note/Create
        [HttpPost]
        public ActionResult Create(NoteModel noteModel)
        {
            noteModel.NoteId = notes.Count + 1;
            notes.Add(noteModel);
            return RedirectToAction("Index");
            
        }

        // GET: Note/Edit/5
        public ActionResult Edit(int id)
        {
            return View(notes.FirstOrDefault(x => x.NoteId == id));
        }

        // POST: Note/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, NoteModel noteModel)
        {
            NoteModel note = notes.FirstOrDefault(x => x.NoteId == id);
            note.Title = noteModel.Title;
            note.Content = noteModel.Content;
            return RedirectToAction("Index");
            
        }

        // GET: Note/Delete/5
        public ActionResult Delete(int id)
        {
            return View(notes.FirstOrDefault(x => x.NoteId == id));
        }

        // POST: Note/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, NoteModel noteModel)
        {   // TODO: Add delete logic here
            NoteModel note = notes.FirstOrDefault(x => x.NoteId == id);
            notes.Remove(note);
            return RedirectToAction("Index");
            
        }
    }
}
