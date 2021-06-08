using NTierProject.CORE.Enum;
using NTierProject.DATAACCESS.Context;
using NTierProject.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NTierProject.DATAACCESS.Repositories.Concrete
{
    public class OrderRepository : Repository<Order>
    {
        private readonly ProjectContext _context;
        public OrderRepository(ProjectContext context) : base(context)
        {
            _context = context;
        }
        public List<Order> ListPendingOrders()
        {
            return GetDefault(x => x.Status == Status.Active && x.Confirmed == false).OrderByDescending(x => x.CreatedDate).ToList();
        }

        public int PendingOrdersCount()
        {
            //return GetDefault(x => x.Status == Status.Active && x.Confirmed == false).ToList().Count();

            return ListPendingOrders().Count();
        }

    }
}
