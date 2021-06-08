using NTierProject.CORE.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTierProject.ENTITIES.Entities
{
    public class Category : CoreEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        //Navigation Property

        public virtual List<Product> Products { get; set; }

    }
}
