using System;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class ContactViewModel
    {
        [Required]
        public String Name { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public String Email { get; set; }
        [Required, DataType(DataType.MultilineText)]
        public String Message { get; set; }
    }
}