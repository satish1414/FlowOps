using FlowOps.FlowOps.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowOps.Application.WorkItems
{
    public interface IWorkItemRepository
    {
        IEnumerable<WorkItem> GetAll();
        WorkItem? GetById(Guid id);
        WorkItem Create(WorkItem workItem);
        WorkItem Update(WorkItem workItem);
        bool Delete(Guid id);
    }
}
