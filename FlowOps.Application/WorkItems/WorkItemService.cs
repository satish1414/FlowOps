using FlowOps.Application.WorkItems;
using FlowOps.FlowOps.Domain.Entities;

namespace FlowOps.FlowOps.Application.WorkItems
{
    public class WorkItemService : IWorkItemService
    {
        private readonly IWorkItemRepository _workItemRepository;
        public WorkItemService(IWorkItemRepository workItemRepository)
        {
           _workItemRepository = workItemRepository;
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
            return _workItemRepository.GetAll();
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
