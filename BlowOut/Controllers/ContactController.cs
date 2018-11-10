﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using BlowOut.Models;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace BlowOut.Controllers
{
    public class ContactController : Controller
    {
        public string name;
        public string email;

        // GET: Contact
        public ActionResult Index()
        {
            ViewBag.Output = "Please call Support at <strong><u>801-555-1212<u><strong>. Thank you!";
            return View();
        }

        public ActionResult Email(string name, string email)
        {
            ViewBag.Output = "Thank you " + name + ". We will send an email to " + email;

            return View("Index");
        }

        /*
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(EmailFormModel model)
        {
            if (ModelState.IsValid)
            {
                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("sophiaeshaw@gmail.com")); 
                message.From = new MailAddress("esjuke@gmail.com");  
                message.Subject = "Your email subject";
                message.Body = string.Format(body, model.FromName, model.FromEmail, model.Message);
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "user@outlook.com",  // replace with valid value
                        Password = "password"  // replace with valid value
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp-mail.outlook.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Sent");
                }
            }
            return View(model);
        }
        */

        public ActionResult Sent()
        {
            return View();
        }
    }
}