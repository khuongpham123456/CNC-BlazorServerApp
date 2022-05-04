using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CNC.Entities
{
    public class Bill
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Total { get; set; }
        public Voucher Voucher { get; set; }
        public int UserId { get; set; } 
        [ForeignKey("UserId")]
        public Customer User { get; set; }

        public ICollection<BillDetail> BillDetails { get; set; }

        public int StatusBill { get; set; }
    }
}
