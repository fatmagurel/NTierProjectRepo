using NTierProject.DATAACCESS.Context;
using NTierProject.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTierProject.DATAACCESS.Repositories.Concrete
{
    public class OrderDetailRepository : Repository<OrderDetail>
    {
        private readonly ProjectContext _context;
        public OrderDetailRepository(ProjectContext context) : base(context)
        {
            _context = context;
        }
    }
}
