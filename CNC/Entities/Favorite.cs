using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CNC.Entities
{
    public class Favorite
    {
        [Key]
        public string Id { get; set; }
        public Product Product { get; set; }
        public Customer User { get; set; }
    }
}
