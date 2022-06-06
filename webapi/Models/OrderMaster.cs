using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Models
{
    public class OrderMaster
    {
        [Key]
        public long OrderMasterId { get; set; }
        [Column(TypeName = "nvarchar(75)")]
        public string OrderNumber { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public Customer Customer { get; set; }//EF will indentify it as a navigational, and not create a new column
        public int CustomerId { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string PMethod { get; set; }
        public decimal GTotal { get; set; }
        [NotMapped]
        public string DeletedOrderItemIds { get; set; }
    }
}
