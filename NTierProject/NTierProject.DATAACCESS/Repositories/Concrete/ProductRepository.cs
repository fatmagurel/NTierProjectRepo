using NTierProject.DATAACCESS.Context;
using NTierProject.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTierProject.DATAACCESS.Repositories.Concrete
{
    public class ProductRepository : Repository<Product>
    {
        private readonly ProjectContext _context;
        public ProductRepository(ProjectContext context) : base(context)
        {
        }
    }
}
