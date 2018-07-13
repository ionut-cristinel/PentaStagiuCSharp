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
            ViewBag.PageCreateDate = DateTime.Now.Date;
            return View(Messages);
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            Message message = Messages.Find(m => m.Id == id);
            if (message == null)
                return HttpNotFound();

            return View(message);
        }

        [HttpGet]
        public ActionResult Delete(long? id)
        {
            Message message = Messages.Find(m => m.Id == id);
            if (message == null)
                return HttpNotFound();

            return View(message);
        }

        [HttpPost]
        public ActionResult Delete(int? id)
        {
            Message message = Messages.Find(m => m.Id == id);
            if (message == null)
                return HttpNotFound();

            Messages.Remove(message);
            return RedirectToAction("Index");
        }

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
            Messages.Add(message);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            Message message = Messages.Find(m => m.Id == id);
            if (message == null)
                return HttpNotFound();

            return View(message);
        }

        [HttpPost]
        public ActionResult Edit(Message message)
        {
            Message messageFromTheList = Messages.Find(m => m.Id == message.Id);
            if (message == null)
                return HttpNotFound();

            messageFromTheList.MessageContent = message.MessageContent;
            messageFromTheList.PostType = message.PostType;
            messageFromTheList.Priority = message.Priority;
            messageFromTheList.IsSticky = message.IsSticky;
            messageFromTheList.TimeOfPosting = DateTime.Now.Date;

            return RedirectToAction("Index");
        }
    }
}