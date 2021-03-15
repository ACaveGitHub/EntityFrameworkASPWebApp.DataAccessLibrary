using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccess.Models
{
   public class Email
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]        
        public String EmailAddress { get; set; }
    }
}
