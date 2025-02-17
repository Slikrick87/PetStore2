﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Data
{
    public class OrderEntity
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public ICollection<ProductEntity> Products { get; set; }

        public OrderEntity()
        {
            this.Products = new List<ProductEntity>();
        }
    }

}
