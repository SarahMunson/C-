using System;
using System.ComponentModel.DataAnnotations;

namespace LoginAndRegistration.Models
{
    public class LogUser
    {
        [Required]
        [EmailAddress]
        public string LEmail {get;set;}
        [Required]
        [DataType(DataType.Password)]
        public string LPassword {get;set;}
    }
}