using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.Models
{
    public class ProductModel
    {
        [Key]
        public int ProductId { get;set; }
        public string Name { get;set ; }
        public string Description { get;set;}
        public decimal Price { get;set; }
        public int Quantity { get;set; }
        public DateTime CreatedDate { get;set; }
    }
}