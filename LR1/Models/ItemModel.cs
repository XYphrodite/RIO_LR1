using System.ComponentModel.DataAnnotations;

namespace LR1.Models
{
    public class ItemModel
    {
        [Key]
        public int id { get; set; }
        public int orderId { get; set; }
        public string Name { get; set; }
    }
}
