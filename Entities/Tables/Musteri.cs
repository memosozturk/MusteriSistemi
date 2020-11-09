using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Xml.Serialization;

namespace Entities.Tables
{
    [Table("TBL_Musteri",Schema="MusteriSistemi")]
    public class Musteri
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [DisplayName("as")]
        [Required]
        [MaxLength(150)]
        [MinLength(5)]
        public string NameSurname { get; set; }
        [Required]
        public String Email { get; set; }

    }
}
