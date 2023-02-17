using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Exercise.Models
{
    public class User
    {
        [Key]
        public string Name { get; set; }
        public string Age { get; set; }
        public string University { get; set; }
    }
}