using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace productsAndCategories.Models
{
    public class Product
    {
        [Key]
        public int ProductId {get;set;}
        [Required]
        public string Name {get;set;}
        [Required]
        public string Description {get;set;}
        [Required]
        public double Price {get;set;}
        public List<Association> Categories {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}