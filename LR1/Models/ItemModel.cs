using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1.Models
{
    public class ItemModel
    {
        [Key]
        public string id { get; set; }
        public string Name { get; set; }
    }
}
