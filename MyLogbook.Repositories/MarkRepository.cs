using Microsoft.EntityFrameworkCore;
using MyLogbook.AppContext;
using MyLogbook.Entities;
using MyLogbook.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLogbook.Repositories
{
    public class MarkRepository : DbRepository<Mark>, IMarkRepository
    {
        public MarkRepository(AppDbContext context) : base(context)
        {
        }
    }
}
