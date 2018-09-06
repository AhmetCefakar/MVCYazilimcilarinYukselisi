using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityFrameworkYapisi.Models
{
    public class Address
    {
        // Field
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] // 'DatabaseGeneratedOption.Identity' ile id otomatik artan yapılıyor
        public int Id { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        // Relations values
        public virtual Person Person { get; set; }
    }
}