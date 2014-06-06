using Mvc.Mailer;
using Web.Models;

namespace Web.Mailers
{ 
    public class ContactMailer : MailerBase, IContactMailer 	
    {
        public ContactMailer()
        {
            MasterName="_Layout";
        }

        public virtual MvcMailMessage Send(ContactViewModel model)
        {
            //ViewBag.Data = someObject;
            ViewData.Model = model;
            return Populate(x =>
            {
                x.Subject = "Thank you for your inquiry";
                x.ViewName = "Send";
                x.To.Add(model.Email);
                x.ReplyToList.Add("contact@bradachristie.info");
            });
        }
    }
}