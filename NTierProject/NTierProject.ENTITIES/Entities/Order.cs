using NTierProject.CORE.Entity.Concrete;
using System;
using System.Collections.Generic;

namespace NTierProject.ENTITIES.Entities
{
    public class Order : CoreEntity
    {
        public Order()
        {
            OrderDetails = new List<OrderDetail>();
        }


        public Guid UserID { get; set; }
        public bool Confirmed { get; set; }
        //Navigation Property
        public virtual User User { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }

    }
}