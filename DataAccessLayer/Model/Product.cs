using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class Product
    {
        [Key]
        public int ProductId {  get; set; }
        [Required, MaxLength(50)]
        public string ProductName {  get; set; }
        [MaxLength(150)]
        public string Description {  get; set; }
        [Required, Range(0.01, double.MaxValue, ErrorMessage = "Price must be Positive")]
        public decimal Price { get; set; }
        [Required, Range(0, int.MaxValue, ErrorMessage ="Stock Quantity must be Non-Negative")]
        public int StockQuantity {  get; set; }
        [Required]
        public bool IsAvailable { get; set; } = true;
    }
}
