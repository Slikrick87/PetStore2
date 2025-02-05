using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Data
{
    public class ProductEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        
        [ForeignKey("Order")]
        public int? OrderId { get; set; }
        public OrderEntity? Order { get; set; }

        public ProductEntity(string name, decimal price, int quantity, string description)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Description = description;

        }
    }
}
