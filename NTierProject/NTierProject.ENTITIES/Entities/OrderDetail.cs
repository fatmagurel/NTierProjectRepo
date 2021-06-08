using NTierProject.CORE.Entity.Concrete;
using System;

namespace NTierProject.ENTITIES.Entities
{
    public class OrderDetail : CoreEntity
    {
        public Guid ProductID { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? Quantity { get; set; }

        //Navigation Property
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }

    }
}
