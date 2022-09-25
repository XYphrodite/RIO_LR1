using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1.Models
{
    internal class OrderItemModel
    {
        [Key]
        public int id { get; set; }
        public int itemId { get; set; }
    }
}
