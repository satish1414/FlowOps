using FlowOps.FlowOps.Domain.Entities;

namespace FlowOps.FlowOps.Application.WorkItems
{
    public interface IWorkItemService
    {
        IEnumerable<WorkItem> GetAll();
        WorkItem? GetById(Guid id);
        WorkItem Create(WorkItem workItem);
        WorkItem Update(WorkItem workItem);
        bool Delete(Guid id);
    }
}
