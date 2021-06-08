using NTierProject.CORE.Entity.Concrete;
using System;
using System.Collections.Generic;

namespace NTierProject.ENTITIES.Entities
{
    public class Product : CoreEntity
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public short? Stock { get; set; }
        public string QuantityPerUnit { get; set; }
        public string ImagePath { get; set; }
        public Guid CategoryID { get; set; }

        //Navigation Property

        public virtual Category Category { get; set; }
        public virtual List<OrderDetail> OrderDetail { get; set; }


    }
}