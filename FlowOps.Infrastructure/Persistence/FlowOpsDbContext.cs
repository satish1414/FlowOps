using FlowOps.FlowOps.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowOps.Infrastructure.Persistence
{
    public class FlowOpsDbContext:DbContext
    {
        public FlowOpsDbContext(DbContextOptions<FlowOpsDbContext> options)
          : base(options)
        {
        }
        public DbSet<WorkItem> WorkItems { get; set; }
    }
}
