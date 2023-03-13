﻿using System.ComponentModel.DataAnnotations;

namespace BulkyBook.Models
{
    
    public class Catagory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DispalyOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}



