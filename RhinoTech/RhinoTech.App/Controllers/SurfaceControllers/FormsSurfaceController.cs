using RhinoTech.App.Classes.Cms;
using RhinoTech.App.Models.HelperModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Umbraco.Web;
using System.Net;

namespace RhinoTech.App.Controllers.SurfaceControllers
{
    public class FormsSurfaceController : SurfaceController
    {
        public JsonResult ContactFormSubmit(ContactFormModel form, string ID)
        {

            
            var currentNode = Umbraco.TypedContent(ID);
            string template = currentNode.GetPropertyValue(DocTypes.ContactPage.EmailTemplate).ToHtmlString();

            string from = "mads@mtweb.dk";
            string adminMail = "madstjornfelt@gmail.com";
            string userEmail = form.Email; //The email the user entered
            MailMessage mailUser = new MailMessage(from, userEmail);
            MailMessage mailAdmin = new MailMessage(from, adminMail);

            mailUser.Subject = "Subject for the user";
            mailAdmin.Subject = "Subject for the admin";
            mailUser.IsBodyHtml = true;
            mailAdmin.IsBodyHtml = true;

            MailAddress replyAddress = new MailAddress(userEmail);
            mailAdmin.ReplyTo = replyAddress;

            var replacedTemplate = template.Replace("##name##", form.Name);
            replacedTemplate = replacedTemplate.Replace("##email##", form.Email);
            replacedTemplate = replacedTemplate.Replace("##phone##", form.Phone);
            replacedTemplate = replacedTemplate.Replace("##address##", form.Address);
            replacedTemplate = replacedTemplate.Replace("##postalcity##", form.PostalCity);
            replacedTemplate = replacedTemplate.Replace("##message##", form.Message);

            mailUser.Body = replacedTemplate;
            mailAdmin.Body = replacedTemplate;

            //Get credentials from web config
            SmtpClient client = new SmtpClient();

            /*
            NetworkCredential basicCredential = new NetworkCredential("aa0f03f0-e819-4310-9210-e281950c393a", "aa0f03f0-e819-4310-9210-e281950c393a");

            client.Host = "smtp.postmarkapp.com";
            client.UseDefaultCredentials = false;
            client.Credentials = basicCredential;
            */

            client.Send(mailUser);
            client.Send(mailAdmin);
            return Json(null);
        }
    }
}