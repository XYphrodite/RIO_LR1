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
        public int id { get; set; }
        public int userId { get; set; }
        public int amount { get; set; }
        public int cost { get; set; }
    }
}
