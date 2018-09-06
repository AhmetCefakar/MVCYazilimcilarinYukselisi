using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityFrameworkYapisi.Models
{
    public class Person
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] // 'DatabaseGeneratedOption.Identity' ile id otomatik artan yapılıyor
        public int Id { get; set; }

        [StringLength(20), Required]
        public string Name { get; set; }

        [StringLength(20), Required]
        public string Surname { get; set; }

        [Required]
        public int Age { get; set; }

        // Relations values
        public virtual List<Address> Addresses { get; set; }
    }
}