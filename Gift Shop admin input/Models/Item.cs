using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gift_Shop_admin_input.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string ImageAddress { get; set; }
        public string Category { get; set; }
        [Range(0,100000)]
        public double Price { get; set; }
        [Range(0, 100000)]
        public int Quantity { get; set; }
        public DateTime Date { get; set; }

    }
}
