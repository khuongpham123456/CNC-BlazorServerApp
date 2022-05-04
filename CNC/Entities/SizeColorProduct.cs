using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CNC.Entities
{
    public class SizeColorProduct
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public int ColorId { get; set; }
        [ForeignKey("ColorId")]
        public Color Color { get; set; }
        public int SizeId { get; set; }
        [ForeignKey("SizeId")]
        public Size Size { get; set; }
        
        public int Quantity { get; set; }
    }
}
