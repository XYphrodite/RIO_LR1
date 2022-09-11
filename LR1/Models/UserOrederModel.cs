using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1.Models
{
    public class UserOrderModel
    {
        [Key]
        public string id { get; set; }
        public string userId { get; set; }
        public string ModelId { get; set; }
    }
}
