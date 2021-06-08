using NTierProject.DATAACCESS.Context;
using NTierProject.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTierProject.DATAACCESS.Repositories.Concrete
{
    public class CategoryRepository : Repository<Category>
    {
        private readonly ProjectContext _context;
        public CategoryRepository(ProjectContext context) : base(context)
        {

        }
    }
}
