using System;
using System.ComponentModel.DataAnnotations;

namespace DojoSurvey2.Models
{
    public class Survey
    {
        [Required]
        public string name {get;set;}

        [Required]
        public string location {get;set;}

        [Required]
        public string language {get;set;}

        public string comment {get;set;}
    }
}