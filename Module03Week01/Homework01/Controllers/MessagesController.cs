using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Homework01.Models;

namespace Homework01.Controllers
{
    public class MessagesController : Controller
    {
        public static List<Message> Messages = new List<Message>();
        public static int Id = 0;

        // GET: Messages
        public ActionResult Index()
        {
            return View(Messages);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            Message message = Messages.Find(m => m.Id == id);
            if (message == null)
                return HttpNotFound();
            else
                return View(message);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            Message message = Messages.Find(m => m.Id == id);
            if (message == null)
                return HttpNotFound();
            else
            {
                Messages.Remove(message);
                return RedirectToAction("Index");
            }
        }


        //  partea de edit prezinta inca erori
        //  ---------- ^ ---------  // 
        [HttpGet]
        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id)
        {
            Message message = Messages.Find(m => m.Id == id);
            if (message == null)
                return HttpNotFound();
            else
            {
                var index = id - 1;
                Messages[index] = message;
                return RedirectToAction("Index");
            }
        }
        //  ---------- ^ ---------  //

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Message message)
        {
            Random random = new Random();
            Id++;
            message.Id = Id;
            message.TimeOfPosting = DateTime.Now.Date;
            message.UserId = random.Next(1, 100);
            message.PostType = (PostType)random.Next(0, 1);
            Messages.Add(message);
            return RedirectToAction("Index");
        }
    }
}