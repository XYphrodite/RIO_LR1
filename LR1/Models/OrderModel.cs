using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1.Models
{
    public class OrderModel
    {
        [Key]
        public string id { get; set; }
        public string OrderItemId { get; set; }
        public int amount { get; set; }
        public int Price { get; set; }
    }
}
