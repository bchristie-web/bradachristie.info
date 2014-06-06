using Mvc.Mailer;
using Web.Models;

namespace Web.Mailers
{ 
    public interface IContactMailer
    {
        MvcMailMessage Send(ContactViewModel model);
    }
}