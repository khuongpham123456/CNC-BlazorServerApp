using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CNC.Entities
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public int Price { get; set; }
        public ICollection<Image> Images { get; set; }
        public ICollection<BillDetail> BillDetails { get; set; }
        public ICollection<SizeColorProduct> SizeColorProducts { get; set; }
        public int Status { get; set; }
    }
}
