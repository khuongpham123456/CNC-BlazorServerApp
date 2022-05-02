using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CNC.Entities
{
    public class Category
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
        public int Status { get; set; }
    }
}
