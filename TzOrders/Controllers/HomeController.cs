using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TzOrders.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net;

namespace TzOrders.Controllers
{
    public class HomeController : Controller
    {
        OrderContext db;

        public HomeController(OrderContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            var orders = db.Orders.Include(p => p.Contragent).Include(p => p.Contact).Include(p => p.ResContact);

            return View(orders.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            SelectList contragent = new SelectList(db.Contragents, "Id", "Name");
            ViewBag.Contragents = contragent;

            SelectList contact = new SelectList(db.Contacts, "Id", "Name");
            ViewBag.Contacts = contact;

            SelectList resContact = new SelectList(db.Contacts, "Id", "Name");
            ViewBag.ResContacts = resContact;

            return View();
        }

        [HttpPost]
        public IActionResult Create(Order order)
        {
            if (ModelState.IsValid)
            {
                db.Orders.Add(order);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(order);
        }


        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Order order = db.Orders.Find(id);
            if (order != null)
            {
                SelectList contragent = new SelectList(db.Contragents, "Id", "Name", order.ContragentId);
                ViewBag.Contragents = contragent;
                SelectList contact = new SelectList(db.Contacts, "Id", "Name", order.ContactId);
                ViewBag.Contacts = contact;
                SelectList resContact = new SelectList(db.Contacts, "Id", "Name", order.ResContactId);
                ViewBag.ResContacts = resContact;
                return View(order);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(Order order)
        {
            db.Entry(order).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return StatusCode((int)HttpStatusCode.BadRequest);
            }

            var order = db.Orders.SingleOrDefault(e => e.Id == id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var order = db.Orders.SingleOrDefault(x => x.Id == id);
            db.Orders.Remove(order ?? throw new InvalidOperationException());
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}