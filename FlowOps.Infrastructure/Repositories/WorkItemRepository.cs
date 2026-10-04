using FlowOps.Application.WorkItems;
using FlowOps.FlowOps.Domain.Entities;
using FlowOps.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowOps.Infrastructure.Repositories
{
    public class WorkItemRepository : IWorkItemRepository
    {

        private readonly FlowOpsDbContext _context;

        public WorkItemRepository(FlowOpsDbContext flowOpsDbContext)
        {
            _context = flowOpsDbContext;
        }

        public WorkItem Create(WorkItem workItem)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WorkItem> GetAll()
        {
            return _context.WorkItems.ToList();
        }

        public WorkItem? GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public WorkItem Update(WorkItem workItem)
        {
            throw new NotImplementedException();
        }
    }
}
