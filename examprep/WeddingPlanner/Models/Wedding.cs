using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace WeddingPlanner.Models
{
    public class Wedding
    {
        [Key]
        public int WeddingId {get;set;}
        [Required]
        public int UserId {get;set;}
        [Required]
        public string NameOne {get;set;}
        [Required]
        public string NameTwo {get;set;}
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date {get;set;}
        [Required]
        public string Address {get;set;}
        public List<Guest> Guests {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}