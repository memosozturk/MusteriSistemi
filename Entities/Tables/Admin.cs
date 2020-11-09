using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Tables
{
    [Table("Admin",Schema ="MusteriSistemi")]
    public class Admin
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        [MaxLength(32)]
        [MinLength(5)]
        public string Username { get; set; }
        [Required]
        [MaxLength(32)]
        [MinLength(8)]
        public string Password { get; set; }
    }
}
