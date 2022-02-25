using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace productsAndCategories.Models
{
    public class Category
    {
        [Key]
        public int CategoryId {get;set;}
        [Required]
        public string Name {get;set;}
        public List<Association> Products {get; set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}