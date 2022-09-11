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
        public string OrderId { get; set; }
        public string ItemId { get; set; }
        public int amount { get; set; }
        public int Price { get; set; }
    }
}
